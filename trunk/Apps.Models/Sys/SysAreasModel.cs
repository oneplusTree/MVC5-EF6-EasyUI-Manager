﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2012-12-11 21:56:03 by App
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apps.Models.Sys
{

    public partial class SysAreasModel
    {
        [NotNullExpression]
        [IsCharExpression] 
        [MaxWordsExpression(50)]
        [Display(Name = "Id")]
        public override string Id { get; set; }

        [MaxWordsExpression(50)]
        [Display(Name = "名称")]
        public override string Name { get; set; }

        [MaxWordsExpression(50)]
        [Display(Name = "上级ID")]
        public override string ParentId { get; set; }

        [Display(Name = "排序")]
        public override int Sort { get; set; }

        [Display(Name = "状态")]
        public override bool Enable { get; set; }

        [Display(Name = "创建时间")]
        public override DateTime CreateTime { get; set; }

        [Display(Name = "直辖市")]
        public override bool IsMunicipality { get; set; }

        [Display(Name = "特别行政区")]
        public override bool IsHKMT { get; set; }

        [Display(Name = "其他")]
        public override bool IsOther { get; set; }

        public string state { get; set; }

        public List<SysAreasModel> clildren { get; set; }


    }
}
