﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GroupDocs.Viewer.UI.Core.Entities
{
    public class Pages : IEnumerable<Page>
    {
        readonly List<Page> _pages;

        public Pages(IEnumerable<Page> pages)
        {
            _pages = pages.ToList();
        }

        public Page this[int index]
        {
            get => _pages[index];
            set => _pages.Insert(index, value);
        }

        public IEnumerator<Page> GetEnumerator() 
            => _pages.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() 
            => GetEnumerator();
    }
}