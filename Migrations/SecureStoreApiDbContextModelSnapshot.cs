﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SecureStore.API.Data;

#nullable disable

namespace SecureStore.Migrations
{
    [DbContext(typeof(SecureStoreApiDbContext))]
    partial class SecureStoreApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SecureStore.API.Data.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Latest iPhone model with A17 chip",
                            Name = "Apple iPhone 15",
                            Price = 999.99m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 2,
                            Description = "Android smartphone with Snapdragon 8 Gen 3",
                            Name = "Samsung Galaxy S24",
                            Price = 899.99m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 3,
                            Description = "Noise-canceling wireless headphones",
                            Name = "Sony WH-1000XM5",
                            Price = 349.99m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            Description = "13-inch ultra-thin laptop with Intel Core i7",
                            Name = "Dell XPS 13",
                            Price = 1499.99m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 5,
                            Description = "Running shoes with responsive cushioning",
                            Name = "Nike Air Zoom Pegasus 39",
                            Price = 119.99m,
                            Stock = 120
                        },
                        new
                        {
                            Id = 6,
                            Description = "Powerful laptop with M2 Pro chip",
                            Name = "Apple MacBook Pro 16-inch",
                            Price = 2399.99m,
                            Stock = 60
                        },
                        new
                        {
                            Id = 7,
                            Description = "Next-gen gaming console with 4K gaming support",
                            Name = "Sony PlayStation 5",
                            Price = 499.99m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 8,
                            Description = "Portable gaming console with 7-inch OLED screen",
                            Name = "Nintendo Switch OLED",
                            Price = 349.99m,
                            Stock = 75
                        },
                        new
                        {
                            Id = 9,
                            Description = "Action camera with 5K video recording",
                            Name = "GoPro HERO12 Black",
                            Price = 399.99m,
                            Stock = 130
                        },
                        new
                        {
                            Id = 10,
                            Description = "Smart speaker with Alexa",
                            Name = "Amazon Echo Dot (5th Gen)",
                            Price = 49.99m,
                            Stock = 500
                        },
                        new
                        {
                            Id = 11,
                            Description = "2-in-1 laptop and tablet with Intel Core i7",
                            Name = "Microsoft Surface Pro 9",
                            Price = 1499.99m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 12,
                            Description = "Fitness tracker with built-in GPS",
                            Name = "Fitbit Charge 5",
                            Price = 149.99m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 13,
                            Description = "Smartwatch with fitness tracking and heart rate monitor",
                            Name = "Apple Watch Series 8",
                            Price = 399.99m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 14,
                            Description = "Noise-canceling headphones with superior sound",
                            Name = "Bose QuietComfort 45",
                            Price = 329.99m,
                            Stock = 90
                        },
                        new
                        {
                            Id = 15,
                            Description = "Cordless vacuum with laser illumination",
                            Name = "Dyson V15 Detect",
                            Price = 699.99m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 16,
                            Description = "65-inch QLED TV with Smart features",
                            Name = "Samsung QLED 4K TV",
                            Price = 1299.99m,
                            Stock = 70
                        },
                        new
                        {
                            Id = 17,
                            Description = "Portable Bluetooth speaker with 360° sound",
                            Name = "Bose SoundLink Revolve+",
                            Price = 299.99m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 18,
                            Description = "DSLR camera with 32.5MP sensor",
                            Name = "Canon EOS 90D",
                            Price = 1299.99m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 19,
                            Description = "Full-frame mirrorless camera with 24.2MP",
                            Name = "Sony A7 III",
                            Price = 1999.99m,
                            Stock = 60
                        },
                        new
                        {
                            Id = 20,
                            Description = "Iconic stand mixer with 10 speeds and attachments",
                            Name = "KitchenAid Stand Mixer",
                            Price = 399.99m,
                            Stock = 120
                        },
                        new
                        {
                            Id = 21,
                            Description = "Electric pressure cooker with multiple cooking options",
                            Name = "Instant Pot Duo 7-in-1",
                            Price = 89.99m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 22,
                            Description = "Smartphone with Google's Tensor G3 chip",
                            Name = "Google Pixel 8 Pro",
                            Price = 899.99m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 23,
                            Description = "Mechanical gaming keyboard with RGB backlighting",
                            Name = "Razer BlackWidow V3",
                            Price = 129.99m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 24,
                            Description = "Wireless gaming mouse with ultra-light design",
                            Name = "Logitech G Pro X Superlight",
                            Price = 149.99m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 25,
                            Description = "Ergonomic office chair with lumbar support",
                            Name = "Herman Miller Aeron Chair",
                            Price = 1395.00m,
                            Stock = 50
                        });
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Administrator with full privileges",
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Regular user with limited privileges",
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice.smith@securestore.com",
                            Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f",
                            UserName = "Alice"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob.jones@securestore.com",
                            Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f",
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 3,
                            Email = "charlie.brown@securestore.com",
                            Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f",
                            UserName = "Charlie"
                        },
                        new
                        {
                            Id = 4,
                            Email = "diana.green@securestore.com",
                            Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f",
                            UserName = "Diana"
                        },
                        new
                        {
                            Id = 5,
                            Email = "eva.white@securestore.com",
                            Password = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f",
                            UserName = "Eva"
                        });
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 5,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Cart", b =>
                {
                    b.HasOne("SecureStore.API.Data.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("SecureStore.API.Data.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.CartItem", b =>
                {
                    b.HasOne("SecureStore.API.Data.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecureStore.API.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Order", b =>
                {
                    b.HasOne("SecureStore.API.Data.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.OrderItem", b =>
                {
                    b.HasOne("SecureStore.API.Data.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecureStore.API.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.UserRole", b =>
                {
                    b.HasOne("SecureStore.API.Data.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecureStore.API.Data.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("SecureStore.API.Data.Models.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
