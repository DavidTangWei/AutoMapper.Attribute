using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using AutoMapper.Attribute;

namespace AttributeTest
{
    [TestClass]
    public class AttributeTest
    {
        [TestMethod]
        public void Test()
        {
            var coupon = new coupon { is_appointment = "不可逾越", amount = "12" };
            Mapper.AddProfile(new CouponProfile());
            var couponMappered = Mapper.Map<Coupon>(coupon);
            Assert.AreEqual(couponMappered.AppointmentInfo, coupon.is_appointment);
            Assert.AreEqual(couponMappered.Amount, 12);
        }
    }

    public class CouponProfile:Profile
    {
        protected override void Configure()
        {
            MapResolver.Map<coupon, Coupon>(this);
            base.Configure();
        }
    }
}
