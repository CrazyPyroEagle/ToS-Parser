# ToS Parser
Network message parsers designed specifically to parse client/server messages used by Town Of Salem.

All types are in the `ToSParser` namespace.

## How to use?
Once you've added this to your project, create an instance of `MessageParser`.
This instance is capable of automatically separating the input into messages and manages a writing buffer to make writing messages easier.
The object has two events: one for read, and one for write.
The read event is triggered once per message, with the buffer, start index, and length of the message.
The write event is triggered every time the parser wants to write to the output.

All you need to do is forward received data to the parser using the `Parse(byte[], int, int)` method.
Every time the parser catches a message, it will trigger the read event.
In the read callback, you are free to parse the message however you want, but there are some objects designed for ease of use.

#### New Parsing Method
The `ClientMesssageParser` and `ServerMessageParser` are designed to parse messages and then forward the messages' contents to the appropriate event.
`ClientMessageParser` is for parsing messages sent by the client, and `ServerMessageParser` is for parsing messages sent by the server.
Both types' constructors accept a `MessageParser` and register the object's read listener.
Once created, you can add a listener to any message type.

#### Old Parsing Method
Use the `ClientMessageType` and `ServerMessageType` enums to determine what type of message you've received.
`ClientMessageType` is for messages sent by the client, and `ServerMessageType` is for messages sent by the server.
After identifying the message type, you may use the parsers in `ClientMessageParsers` and `ServerMessageParsers` to easily extract additional data.

#### Formatting Messages
`MessageParser` has a large number of extension methods to make sending messages vastly simpler and less error-prone.
These extension methods are defined in the `ClientMessageParsers` and `ServerMessageParsers` classes.

Here's an example of a program that automatically accepts any party invitation or friend request it receives.

```C#
using System;
using System.Net.Sockets;
using ToSParser;

class ParseDemo
{
    private const uint BUILD_NUMBER = 9706u;    // Likely outdated, replace with the fourth component of the official client version number

    private Socket socket;
    private MessageParser parser;
    private byte[] readBuffer;

    public static void Main(string[] args)
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect("live4.tos.blankmediagames.com", 3600);
        new ParseDemo(socket);
    }

    private ParseDemo(Socket socket)
    {
        this.socket = socket;
        parser = new MessageParser();
        ServerMessageParser messageParser = new ServerMessageParser(parser);
        parser.MessageWrite += (buffer, index, length) => socket.Send(buffer, index, length, SocketFlags.None);
        messageParser.PartyInviteNotification += OnPartyInviteNotification;
        messageParser.FriendRequestNotifications += OnFriendRequestNotifications;
        readBuffer = new byte[4096];
        QueueReceive();
        // Send the authentication message here.
        // e.g. (Note: I do not recommend the use of legacy authentication due to its use of plaintext password transmission.)
        // parser.Authenticate(AuthenticationModeID.BMG_FORUMS, false, BUILD_NUMBER, "ExampleAccount", "examplepassword");
    }

    private void OnPartyInviteNotification(uint userID, string username)
    {
        parser.RespondPartyInvite(PartyInviteResponse.ACCEPTING, userID);
        parser.RespondPartyInvite(PartyInviteResponse.ACCEPTED, userID);
    }

    private void OnFriendRequestNotifications(IEnumerable<(string username, uint userID)> notifications)
    {
        foreach ((string username, uint userID) in notifications)
        {
            parser.AcceptFriend(username, userID);
        }
    }

    private void ParseMessage(byte[] buffer, int index, int length)
    {
        switch ((ServerMessageType)buffer[index++])
        {
            case ServerMessageType.FRIEND_REQUEST_NOTIFICATIONS:
                ServerMessageParsers.FRIEND_REQUEST_NOTIFICATIONS.Build(buffer, index, length).Parse(p =>
                {
                    RootParser root = p.Parse(out string username).Parse(out uint userID);
                    parser.AcceptFriend(username, userID);
                    return root;
                }, out _);
                break;
        }
    }

    private void Receive(IAsyncResult result)
    {
        try
        {
            parser.Parse(readBuffer, 0, socket.EndReceive(result));
            QueueReceive();
        }
        catch (SocketException)
        {
            socket.Close();
        }
    }

    private void QueueReceive() => socket.BeginReceive(readBuffer, 0, readBuffer.Length, SocketFlags.None, Receive, null);
}
```
