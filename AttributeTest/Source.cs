using AutoMapper.Attribute;
using System;
using System.Collections.Generic;

namespace AttributeTest
{
    public class coupon
    {
        [MapTo(typeof(Coupon), nameof(Coupon.Title))]
        public string coupon_title { get; set; }

        public string category { get; set; }

        [MapTo(typeof(Coupon), nameof(Coupon.OriginalAmount))]
        public string original_amount { get; set; }

        [MapTo(typeof(Coupon), nameof(Coupon.Amount))]
        public string amount { get; set; }

        [MapTo(typeof(Coupon), nameof(Coupon.MinimumSpending))]
        public string minimum_spending { get; set; }
        public bool is_overlap { get; set; }
        public string other_rules { get; set; }
        public object[] valid_businesses { get; set; }
        public string valid_time_cn { get; set; }
        public string limit_hint { get; set; }
        public string uid { get; set; }
        public string promotion { get; set; }

        [MapTo(typeof(Coupon), nameof(Coupon.Description))]
        public string description { get; set; }

        [MapTo(typeof(Coupon), nameof(Coupon.AppointmentInfo))]
        public string is_appointment { get; set; }
        public bool is_change { get; set; }

        [MapTo(typeof(Coupon), nameof(Coupon.Share))]
        public string is_share { get; set; }
        public bool is_takeaway { get; set; }

        [MapTo(typeof(Coupon), nameof(Coupon.AvailTimeRange))]
        public string available_time { get; set; }
        public string excluded_things { get; set; }
        public bool available_now { get; set; }
        public string pic { get; set; }
        public List<string> images { get; set; }
    }

    public class Coupon
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AppointmentInfo { get; set; }             // is_appointment
        public decimal OriginalAmount { get; set; }             // 物品券原价
        public decimal Amount { get; set; }                     // 代金券金额, 折扣券折扣, 物品券优惠价, 其他券没有意义
        public decimal MinimumSpending { get; set; }            // 代金券实际支付金额
        // 同享信息
        public string Share { get; set; }
        // 可用时间段
        public string AvailTimeRange { get; set; }
    }
}
