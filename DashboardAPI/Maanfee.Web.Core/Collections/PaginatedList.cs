﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maanfee.Web.Core
{
    public class PaginatedList<T> //: List<T>
    {
        public PaginatedList(List<T> items, int count = 0, int pageIndex = 1, int pageSize = 10)
        {
            PageIndex = pageIndex;
            //TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            TotalPages = count;

            //this.AddRange(items);
            List = items;
        }

        public List<T> List { get; private set; } = new List<T>();

        public int PageIndex { get; private set; }

        public int TotalPages { get; private set; }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex = 1, int pageSize = 10)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        // Alternative
        public static async Task<PaginatedList<T>> CreateAsync(IList<T> source, int pageIndex = 1, int pageSize = 10)
        {
            var count = await Task.Run(() => source.Count());
            var items = await Task.Run(() => source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList());
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
