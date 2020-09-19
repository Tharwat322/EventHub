﻿using GigHub.Core.Repositories;

namespace GigHub.Core
{
    public interface IUnitOfWork
    {

        IGigRepository Gigs { get; }
        IAttendanceRepository Attendances { get; }
        IFollowingRepository Followings { get; }
        IGenreRepository Genres { get; }
        IApplicationUserRepository Users { get; }
        INotificationRepository Notifications { get; }
        IUserNotificationRepository UserNotifications { get; }
  

        void Complete();
    }
}