---run alignment script
declare @dPosted as datetime

set @dPosted =  (select  top 1 BatchPostingDate from [dbo].[batchpostinglogs] order by  BatchPostingDate desc)

--Align all products of warehouseadjustment to dssr
insert into  dssrhistory 
select 0,0,0,0,0,0,0,0,0,0,0,availablestock
,availablestock,p.dealerprice * availablestock,@dPosted,
 case when (select top 1 productmaster_productgroup from productmasters p where p.id = WarehouseAdjustment_ProductMaster  ) = 1 then 1 else 0 end,
 WarehouseAdjustment_ProductMaster, 1,( select top 1 id from aspnetusers where username = 'Encoder') , null,null,null,null,null
 
 from warehouseadjustments w
left outer join productmasters p on p.id = w.WarehouseAdjustment_ProductMaster
where WarehouseAdjustment_ProductMaster not in (
select DSSRHistory_ProductMaster 
from dssrhistory where day(dateposted) = day(@dPosted) and Month(dateposted) = Month(@dPosted) and Year(dateposted) = Year(@dPosted)
)


--Align all EOH of  dssr from warehouseadjustment
update x set x.endofhand = x.availablestock ,
 x.adjustment = case when  x.availablestock > x.beginningOfHand 
				then   x.availablestock - x.beginningOfHand 
				else   x.beginningOfHand - x.availablestock end ,
 x.Amount = x.dealerprice *  x.availablestock
from(select d.*,w.availablestock,p.dealerprice from [dbo].[DSSRHistory]  d
left outer join warehouseadjustments w on w.WarehouseAdjustment_ProductMaster = d.DSSRHistory_ProductMaster
left outer join productmasters p on p.id = d.DSSRHistory_ProductMaster
where day(dateposted) = day(@dPosted) and Month(dateposted) = Month(@dPosted) and Year(dateposted) = Year(@dPosted)) x

select d.*,w.availablestock from [dbo].[DSSRHistory]  d
left outer join warehouseadjustments w on w.WarehouseAdjustment_ProductMaster = d.DSSRHistory_ProductMaster
where day(dateposted) = day(@dPosted) and Month(dateposted) = Month(@dPosted) and Year(dateposted) = Year(@dPosted)
