﻿using HeBianGu.Base.WpfBase;

namespace HeBianGu.ExplorePlayer.Base.Model
{

    public class mbc_db_extendtype : mbc_db_modelbase
    {
        [Display(Name = "扩展名称")]
        public string Name { get; set; } 

        [Display(Name = "扩展值")]
        public string Value { get; set; }

        [Display(Name = "所属类型")]
        public string MediaType { get; set; }
        

        [Display(Name = "显示名称")]
        public string Text { get; set; } 

    }
}
