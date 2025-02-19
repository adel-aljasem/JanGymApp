﻿namespace JanGym.Data
{
    public class Component
    {
        public string type { get; set; }
        public List<Parameter> parameters { get; set; }
    }

    public class Language
    {
        public string code { get; set; }
    }

    public class Parameter
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Root
    {
        public string messaging_product { get; set; }
        public string to { get; set; }
        public string type { get; set; }
        public Template template { get; set; }
    }

    public class Template
    {
        public string name { get; set; }
        public Language language { get; set; }
        public List<Component> components { get; set; }
    }

}
