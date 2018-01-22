﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace part4.Migrations
{
    public partial class ProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    description = table.Column<string>(maxLength: 700, nullable: false),
                    image = table.Column<string>(maxLength: 100, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}