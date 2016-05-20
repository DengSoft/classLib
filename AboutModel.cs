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
        /// 信息数据集合
        /// </summary>
        public List<AboutDto> AboutList
        {
            get; 
            set;
        }
	
	/// <summary>
        /// 姓名
        /// </summary>	
	public int Name
	{
		get;
		set;
	}
	
	/// <summary>
        /// 节日名称
        /// </summary>	
	public int ActiveName
	{
		get;
		set;
	}
    }
}
