﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetSignalR.Models;

namespace DotNetSignalR.Services
{
    public interface IChatRoomService
    {
        Task<Guid> CreateRoom(string connectionId);

        Task<Guid> GetRoomForConnectionId(string connectionId);

        Task SetRoomName(Guid roomId, string name);

        Task AddMessage(Guid roomId, ChatMessage message);

        Task<IEnumerable<ChatMessage>> GetMessageHistory(Guid roomId);

        Task<IReadOnlyDictionary<Guid, ChatRoom>> GetAllRooms();
    }
}
