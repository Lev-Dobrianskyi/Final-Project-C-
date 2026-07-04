using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAppServer
{
    internal class DbControll
    {
        public static void ResetDb()
        {
            using (var context = new AppContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
