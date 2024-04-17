﻿#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Boogie;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Microsoft.Dafny.LanguageServer.IntegrationTest.Util {

  /// <summary>
  /// Test-class to receive and handle notifications sent by the language server.
  /// </summary>
  /// <typeparam name="TNotification">The type of the notifications sent by the language server.</typeparam>
  public class TestNotificationReceiver<TNotification> {

    private readonly AsyncQueue<TNotification> notifications = new();
    private readonly List<TNotification> notificationHistory = new();
    private readonly ILogger logger;

    public TestNotificationReceiver(ILogger logger) {
      this.logger = logger;
    }

    public void NotificationReceived(TNotification request) {
      Assert.NotNull(request);
      logger.LogTrace($"Received {request.Stringify()}");

      lock (this) {
        notificationHistory.Add(request);
        notifications.Enqueue(request);
      }
    }

    public bool HasPendingNotifications => notifications.Size != 0;

    public IReadOnlyList<TNotification> History => notificationHistory;

    public void ClearHistory() {
      notificationHistory.Clear();
    }

    public TNotification? GetLatestAndClearQueue(Func<TNotification, bool> predicate) {
      lock (this) {
        while (notifications.Size > 0) {
          _ = notifications.Dequeue(CancellationToken.None);
        }

        return History.LastOrDefault(predicate);
      }
    }

    public Task<TNotification> AwaitNextNotificationAsync(CancellationToken cancellationToken) {
      var start = DateTime.Now;
      try {
        return notifications.Dequeue(cancellationToken);
      } catch (OperationCanceledException) {
        var last = History.Any() ? History[^1].Stringify() : "none";
        logger.LogInformation($"Waited for {(DateTime.Now - start).Seconds} seconds for new notification.\n" +
                              $"Last received notification was {last}");
        throw;
      }
    }
  }
}
