using System.Security.AccessControl;
using System;
using Microsoft.EntityFrameworkCore;

namespace DEVinCar.Domain.Models;
public class Delivery
{
    //teste alte��ao para github
    public int Id { get; set; }
    public DateTime DeliveryForecast { get; set; }
    public int AddressId { get; set; }
    public int SaleId { get; set; }
    public virtual Address Address { get; set; }
    public virtual Sale Sale { get; set; }
    public Delivery()
    {
    }  
}
