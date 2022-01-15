﻿namespace MultiWorldLib.Messaging
{
    public enum MWMessageType
    {
        InvalidMessage=0,
        SharedCore=1,
        ConnectMessage,
        ReconnectMessage,
        DisconnectMessage,
        JoinMessage,
        JoinConfirmMessage,
        LeaveMessage,
        ItemReceiveMessage,
        ItemReceiveConfirmMessage,
        ItemSendMessage,
        ItemSendConfirmMessage,
        NotifyMessage,
        ReadyConfirmMessage,
        ReadyDenyMessage,
        PingMessage,
        ReadyMessage,
        ResultMessage,
        SaveMessage,
        SetupMessage,
        RandoGeneratedMessage,
        UnreadyMessage,
        InitiateGameMessage,
        RequestRandoMessage,
        AnnounceCharmNotchCostsMessage,
        RequestCharmNotchCostsMessage,
        ConfirmCharmNotchCostsReceivedMessage,
        ItemsSendMessage,
        ItemsSendConfirmMessage,
        InitiateSyncGameMessage,
        ApplySettingsMessage,
        UploadSettingsMessage,
        VisitStateChangedMessage,
        VisitStateChangedConfirmMessage,
        TransitionFoundMessage
    }
}
