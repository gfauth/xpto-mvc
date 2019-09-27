using DataModel.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Models
{
    public class ExceptionModel
    {
        public int Id { get; private set; }
        public int Code { get; private set; }
        public string Message { get; private set; }
        public string InnerMessage { get; private set; }
        public DateTime IssueTime { get; private set; }

        public ExceptionModel()
        {

        }

        public ExceptionModel(Exception ex)
        {
            InnerMessage = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
            Code = ex.InnerException != null ? ex.InnerException.HResult : 0;
            IssueTime = DateTime.UtcNow;
            Message = ex.Message;
        }

        public void ExceptionLog(DatabaseContext context)
        {
            _ = context.Add(this);
            context.SaveChangesAsync();
        }
    }
}
