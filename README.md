### Usage

traditional usage of automapper
```
CreateMap<coupon,Coupon>()
.ForMember(dest=>dest.Id,opt=>opt.MapFrom(src=>src.ID));
```
It is not convenient. Because for every single property map, wo must use linq to sepecfic the source and destination porperty.

with attribute we can simplify the mapper:
```
public class coupon
{
    [MapTo(typeof(Coupon),nameof(Coupon.ID))]
    public string Id {get; set;}
}
```
