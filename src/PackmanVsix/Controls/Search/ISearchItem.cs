﻿namespace PackmanVsix.Controls.Search
{
    public interface ISearchItem
    {
        string CollapsedItemText { get; }

        string Alias { get; }

        bool IsMatchForSearchTerm(string searchTerm);
    }
}
