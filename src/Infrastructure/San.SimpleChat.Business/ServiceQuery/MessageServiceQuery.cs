﻿using San.SimpleChat.Core.Business_Interface.ServiceQuery;
using San.SimpleChat.Core.Entities;
using San.SimpleChat.Core.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace San.SimpleChat.Business.ServiceQuery
{
    public class MessageServiceQuery: IMessageServiceQuery
    {
        private readonly IUnitOfWork unitOfWork;
        public MessageServiceQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        IEnumerable<Message> IMessageServiceQuery.GetAll()
        {
            try
            {
                var messages = this.unitOfWork.Repository<Message>().Get().ToList();
                return messages;
            }
            catch (Exception)
            {

                throw;
            }

        }
        IEnumerable<Message> IMessageServiceQuery.GetReceivedMessages(string userId)
        {
            try
            {
                var messages = this.unitOfWork.Repository<Message>().Get().Where(x=>x.Receiver==userId).ToList();
                return messages;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
