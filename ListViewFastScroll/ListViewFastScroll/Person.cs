﻿namespace ListViewFastScroll
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName => $"{LastName}, {FirstName}";
    }
}