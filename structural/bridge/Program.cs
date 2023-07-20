using bridge;

Message systemMessage = new SystemMessage(EmailSender.Of());
Message userMessage = new UserMessage(NotificationSender.Of());

systemMessage.Send();
userMessage.Send();
