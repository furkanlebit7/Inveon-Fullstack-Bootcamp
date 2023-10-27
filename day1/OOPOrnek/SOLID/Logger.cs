using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.SOLID
{
    public class Logger
    {
        public DbLog dbLog;
        public XmlLog xmlLog;

        public Logger(DbLog dbLog, XmlLog xmlLog)
        {
            this.dbLog = dbLog;
            this.xmlLog = xmlLog;
        }
        public void LogYaz(LogType type, string value)
        {
            switch (type)
            {
                case LogType.Xml:
                    xmlLog.XmlKayit(value);
                    break;
                case LogType.Db:
                    dbLog.DbKayit(value);
                    break;
            }
        }
    }
}
