﻿namespace Assets.Scripts.Runtime.PlaySceneLogic.ChessPiece
{
    using System;
    using global::Runtime.PlaySceneLogic.ChessPiece;
    using global::Runtime.UI;
    using UniRx;

    public class GameLog
    {
        public string                Id;
        public DateTime              Time;
        public GameResultStatus      Status;
        public PieceTeam             winTeam;
        public float                 PlayerWhiteTimeRemaining;
        public float                 PlayerBlackTimeRemaining;

        public GameLog() { }

        public GameLog(string id, DateTime time, GameResultStatus status, PieceTeam winTeam)
        {
            this.Id      = id;
            this.Time    = time;
            this.Status  = status;
            this.winTeam = winTeam;
        }

        public GameLog(string id, DateTime time, GameResultStatus status, PieceTeam winTeam, float playerWhiteTimeRemaining, float playerBlackTimeRemaining) : this(id, time, status, winTeam)
        {
            this.PlayerWhiteTimeRemaining = playerWhiteTimeRemaining;
            this.PlayerBlackTimeRemaining = playerBlackTimeRemaining;
        }
    }
}