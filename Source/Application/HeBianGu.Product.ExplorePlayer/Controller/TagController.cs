﻿using HeBianGu.Base.WpfBase;
using HeBianGu.Domain.MvcRespository;
using HeBianGu.ExplorePlayer.Base.Model;
using HeBianGu.ExplorePlayer.Respository.IService;
using HeBianGu.ExplorePlayer.Respository.Serice;
using HeBianGu.General.WpfControlLib;
using HeBianGu.General.WpfMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Product.ExplorePlayer
{
    [Route("Tag")]
    class TagController : EntityBaseController<mbc_db_tagtype, TagViewModel, ITagRespository>
    {

    }
}
