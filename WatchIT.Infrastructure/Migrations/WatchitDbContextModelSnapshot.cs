﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WatchIT.Infrastructure;

namespace WatchIT.Infrastructure.Migrations
{
    [DbContext(typeof(WatchitDbContext))]
    partial class WatchitDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WatchIT.Domain.Model.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("channelDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("channelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("Channel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            channelDescription = "Satyamev Jayate 1.1M subscribers Description Satyamev Jayate - a TV show hosted by Aamir Khan that discussed social issues in India through three seasons that went on air between 2012 and 2014.Starting early 2016,the shows core team runs Paani Foundation.",
                            channelName = "Satyamev Jayate",
                            created_at = new DateTime(2021, 1, 29, 23, 35, 6, 6, DateTimeKind.Utc).AddTicks(6473),
                            updated_at = new DateTime(2021, 1, 29, 23, 35, 6, 6, DateTimeKind.Utc).AddTicks(7612),
                            userId = 2
                        },
                        new
                        {
                            Id = 2,
                            channelDescription = "Wouldn’t it be just great to keep pace with what your stars are doing, never leaving you in a dull moment? Bollywood Spy.in is here to be your entertainment and B Town partner. Look nowhere, go nowhere, simply catch up with us for fresh feeds.",
                            channelName = "Bollywood Spy",
                            created_at = new DateTime(2021, 1, 29, 23, 35, 6, 7, DateTimeKind.Utc).AddTicks(1375),
                            updated_at = new DateTime(2021, 1, 29, 23, 35, 6, 7, DateTimeKind.Utc).AddTicks(1412),
                            userId = 1
                        });
                });

            modelBuilder.Entity("WatchIT.Domain.Model.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Thumbnail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("channelId")
                        .HasColumnType("int");

                    b.Property<byte[]>("content")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("channelId");

                    b.ToTable("Musics");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.MusicComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("commentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("musicId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("musicId");

                    b.HasIndex("userId");

                    b.ToTable("MusicComments");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.MusicLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("musicId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("musicId");

                    b.HasIndex("userId");

                    b.ToTable("MusicLikes");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.MusicPlaylist", b =>
                {
                    b.Property<int>("musicId")
                        .HasColumnType("int");

                    b.Property<int>("playlistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("musicId", "playlistId");

                    b.HasIndex("playlistId");

                    b.ToTable("MusicPlaylists");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("playlistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "dtmw8z.sp@gmail.com",
                            IsAdmin = true,
                            Password = "E/XH1MpKAjCSH7uWc+iXM7MvyQVmDDqjdQs8Db+OWW89lX16OrRH8FkIcl1Lr/4UzztdfdRgeKTjl4MlKVgPNg==",
                            fullName = "Susan Babu Pandey"
                        },
                        new
                        {
                            Id = 2,
                            Email = "shailabchapagain34@gmail.com@gmail.com",
                            IsAdmin = false,
                            Password = "E/XH1MpKAjCSH7uWc+iXM7MvyQVmDDqjdQs8Db+OWW89lX16OrRH8FkIcl1Lr/4UzztdfdRgeKTjl4MlKVgPNg==",
                            fullName = "Shailab Chapagain"
                        });
                });

            modelBuilder.Entity("WatchIT.Domain.Model.UserSubscribesChannel", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("channelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("subscribedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("userId", "channelId");

                    b.HasIndex("channelId");

                    b.ToTable("UserSubscribesChannels");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Thumbnail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("channelId")
                        .HasColumnType("int");

                    b.Property<byte[]>("content")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("channelId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.VideoComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("commentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("videoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.HasIndex("videoId");

                    b.ToTable("VideoComments");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.VideoLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("videoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.HasIndex("videoId");

                    b.ToTable("VideoLikes");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.VideoPlaylist", b =>
                {
                    b.Property<int>("videoId")
                        .HasColumnType("int");

                    b.Property<int>("playlistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("videoId", "playlistId");

                    b.HasIndex("playlistId");

                    b.ToTable("VideoPlaylists");
                });

            modelBuilder.Entity("WatchIT.Domain.Model.Channel", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.User", "User")
                        .WithOne("Channel")
                        .HasForeignKey("WatchIT.Domain.Model.Channel", "userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.Music", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.Channel", "Channel")
                        .WithMany("Musics")
                        .HasForeignKey("channelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.MusicComment", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.Music", "Music")
                        .WithMany("MusicComments")
                        .HasForeignKey("musicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WatchIT.Domain.Model.User", "User")
                        .WithMany("MusicComments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.MusicLike", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.Music", "Music")
                        .WithMany("MusicLikes")
                        .HasForeignKey("musicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WatchIT.Domain.Model.User", "User")
                        .WithMany("MusicLikes")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.MusicPlaylist", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.Music", "Music")
                        .WithMany("MusicPlaylists")
                        .HasForeignKey("musicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WatchIT.Domain.Model.Playlist", "Playlist")
                        .WithMany("MusicPlaylists")
                        .HasForeignKey("playlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.Playlist", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.UserSubscribesChannel", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.Channel", "Channel")
                        .WithMany("UserSubscribesChannels")
                        .HasForeignKey("channelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WatchIT.Domain.Model.User", "User")
                        .WithMany("UserSubscribesChannels")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.Video", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.Channel", "Channel")
                        .WithMany("Videos")
                        .HasForeignKey("channelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.VideoComment", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.User", "User")
                        .WithMany("VideoComments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WatchIT.Domain.Model.Video", "Video")
                        .WithMany("VideoComments")
                        .HasForeignKey("videoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.VideoLike", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.User", "User")
                        .WithMany("VideoLikes")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WatchIT.Domain.Model.Video", "Video")
                        .WithMany("VideoLikes")
                        .HasForeignKey("videoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WatchIT.Domain.Model.VideoPlaylist", b =>
                {
                    b.HasOne("WatchIT.Domain.Model.Playlist", "Playlist")
                        .WithMany("VideoPlaylists")
                        .HasForeignKey("playlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WatchIT.Domain.Model.Video", "Video")
                        .WithMany("VideoPlaylists")
                        .HasForeignKey("videoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
