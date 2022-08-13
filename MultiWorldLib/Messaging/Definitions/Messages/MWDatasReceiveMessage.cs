﻿namespace MultiWorldLib.Messaging.Definitions.Messages
{
    [MWMessageType(MWMessageType.DatasReceiveMessage)]
    public class MWDatasReceiveMessage : MWConfirmableMessage
    {
        public List<(string Label, string Data)> Datas { get; set; }
        public string From { get; set; }

        public MWDatasReceiveMessage()
        {
            MessageType = MWMessageType.DatasReceiveMessage;
        }
    }

    public class MWDatasReceiveDefinition : MWMessageDefinition<MWDatasReceiveMessage>
    {
        public MWDatasReceiveDefinition() : base(MWMessageType.DatasReceiveMessage)
        {
            Properties.Add(new MWMessageProperty<List<(string, string)>, MWDatasReceiveMessage>(nameof(MWDatasReceiveMessage.Datas)));
            Properties.Add(new MWMessageProperty<string, MWDatasReceiveMessage>(nameof(MWDatasReceiveMessage.From)));
        }
    }
}