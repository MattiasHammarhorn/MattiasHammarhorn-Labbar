using Labb_10___Delegater.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_10___Delegater.Managers.BookManager;

namespace Labb_10___Delegater
{
    class Runtime
    {
        public void Start()
        {
            var bookManager = new BookManager();

            BookFilter isNovelFilter = new BookFilter(bookManager.IsNovel);
            BookFilter isShortStoryFilter = new BookFilter(bookManager.IsShortStory);
            BookFilter isMysteryFilter = new BookFilter(bookManager.IsMystery);
            BookFilter isFantasyFilter = new BookFilter(bookManager.IsFantasy);
            BookFilter isRomanceFilter = new BookFilter(bookManager.IsRomance);
            BookFilter isCheap = new BookFilter(bookManager.IsCheap);
            BookFilter isExpensiveFilter = new BookFilter(bookManager.IsExpensive);
            bookManager.PrintWhere(isExpensiveFilter);
        }
    }
}
