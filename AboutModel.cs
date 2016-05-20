using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFS.Core.External.Contracts.Dto.App;

namespace MobileApp.ResModels
{
    public class AboutModel:BaseResModel
    {
        /// <summary>
        /// 关于大丰收的信息数据集合
        /// </summary>
        public List<AboutDto> AboutList
        {
            get; 
            set;
        }
    }
}