using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Entities
{
    public enum Status { Active = 1, Modified = 2, Passive = 3 }

    public abstract class BaseEntity
    {
        public int Id { get; set; }

        DateTime _createDate = DateTime.Now;
        public DateTime CreateDate
        {
            get => _createDate;
            set => _createDate = value;
        }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }


        Status _status = Status.Active;
        public Status Status
        {
            get => _status;
            set => _status = value;
        }

        public string CreatedIp { get; set; }
        public string UpdateIp { get; set; }
        public string DeletedIp { get; set; }

        public string CreateMachineName { get; set; }
        public string UpdateMachineName { get; set; }
        public string DeleteMachineName { get; set; }


    }
}