﻿using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AuctionService.Data;

public class AuctionDbContext :DbContext
{
    public AuctionDbContext(DbContextOptions options)  : base(options)
    {

    }

    public DbSet<Auction> Auctions {get;set;}

    

}
