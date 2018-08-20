﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cloudscribe.SimpleContent.Models;
using cloudscribe.SimpleContent.Storage.EFCore.MSSQL;

namespace cloudscribe.SimpleContent.Storage.EFCore.MSSQL.Migrations
{
    [DbContext(typeof(SimpleContentDbContext))]
    partial class SimpleContentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cloudscribe.SimpleContent.Models.ContentHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("ArchivedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ArchivedUtc");

                    b.Property<string>("Author")
                        .HasMaxLength(255);

                    b.Property<string>("CategoriesCsv");

                    b.Property<string>("Content");

                    b.Property<string>("ContentId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.Property<string>("ContentSource")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DraftAuthor")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent");

                    b.Property<DateTime?>("DraftPubDate");

                    b.Property<string>("DraftSerializedModel");

                    b.Property<bool>("IsDraftHx");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedByUser")
                        .HasMaxLength(100);

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaHtml");

                    b.Property<string>("MetaJson");

                    b.Property<int>("PageOrder");

                    b.Property<string>("ParentId")
                        .HasMaxLength(255);

                    b.Property<string>("ParentSlug")
                        .HasMaxLength(255);

                    b.Property<string>("ProjectId");

                    b.Property<DateTime?>("PubDate");

                    b.Property<string>("SerializedModel");

                    b.Property<string>("Serializer")
                        .HasMaxLength(50);

                    b.Property<string>("Slug")
                        .HasMaxLength(255);

                    b.Property<string>("TeaserOverride");

                    b.Property<string>("TemplateKey")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ViewRoles");

                    b.Property<bool>("WasDeleted");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("ContentSource");

                    b.HasIndex("CorrelationKey");

                    b.HasIndex("CreatedByUser");

                    b.HasIndex("LastModifiedByUser");

                    b.HasIndex("Title");

                    b.ToTable("cs_ContentHistory");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Models.ProjectSettings", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<bool>("AddBlogToPagesTree")
                        .HasColumnType("bit");

                    b.Property<bool>("BlogMenuLinksToNewestPost")
                        .HasColumnType("bit");

                    b.Property<string>("BlogPageNavComponentVisibility")
                        .HasMaxLength(255);

                    b.Property<int>("BlogPagePosition");

                    b.Property<string>("BlogPageText")
                        .HasMaxLength(255);

                    b.Property<string>("CdnUrl")
                        .HasMaxLength(255);

                    b.Property<string>("ChannelCategoriesCsv")
                        .HasMaxLength(255);

                    b.Property<string>("ChannelRating")
                        .HasMaxLength(100);

                    b.Property<int>("ChannelTimeToLive");

                    b.Property<string>("CommentNotificationEmail")
                        .HasMaxLength(100);

                    b.Property<string>("CopyrightNotice")
                        .HasMaxLength(255);

                    b.Property<int>("DaysToComment");

                    b.Property<string>("DefaultContentType")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<int>("DefaultFeedItems");

                    b.Property<string>("DefaultPageSlug")
                        .HasMaxLength(255);

                    b.Property<string>("Description");

                    b.Property<string>("DisqusShortName")
                        .HasMaxLength(100);

                    b.Property<string>("FacebookAppId")
                        .HasMaxLength(100);

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<bool>("IncludePubDateInPostUrls")
                        .HasColumnType("bit");

                    b.Property<string>("LanguageCode")
                        .HasMaxLength(10);

                    b.Property<string>("LocalMediaVirtualPath")
                        .HasMaxLength(255);

                    b.Property<string>("ManagingEditorEmail")
                        .HasMaxLength(100);

                    b.Property<int>("MaxFeedItems");

                    b.Property<bool>("ModerateComments")
                        .HasColumnType("bit");

                    b.Property<int>("PostsPerPage");

                    b.Property<string>("PubDateFormat")
                        .HasMaxLength(75);

                    b.Property<string>("Publisher")
                        .HasMaxLength(255);

                    b.Property<string>("PublisherEntityType")
                        .HasMaxLength(50);

                    b.Property<string>("PublisherLogoHeight")
                        .HasMaxLength(20);

                    b.Property<string>("PublisherLogoUrl")
                        .HasMaxLength(255);

                    b.Property<string>("PublisherLogoWidth")
                        .HasMaxLength(20);

                    b.Property<string>("RecaptchaPrivateKey")
                        .HasMaxLength(255);

                    b.Property<string>("RecaptchaPublicKey")
                        .HasMaxLength(255);

                    b.Property<string>("RemoteFeedProcessorUseAgentFragment")
                        .HasMaxLength(255);

                    b.Property<string>("RemoteFeedUrl")
                        .HasMaxLength(255);

                    b.Property<bool>("ShowFeaturedPostsOnDefaultPage")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowRecentPostsOnDefaultPage")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowTitle")
                        .HasColumnType("bit");

                    b.Property<string>("SiteName")
                        .HasMaxLength(200);

                    b.Property<byte>("TeaserMode")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue((byte)0);

                    b.Property<int>("TeaserTruncationLength")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(20);

                    b.Property<byte>("TeaserTruncationMode")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue((byte)0);

                    b.Property<string>("TimeZoneId")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<string>("TwitterCreator")
                        .HasMaxLength(100);

                    b.Property<string>("TwitterPublisher")
                        .HasMaxLength(100);

                    b.Property<bool>("UseDefaultPageAsRootNode")
                        .HasColumnType("bit");

                    b.Property<string>("WebmasterEmail")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("cs_ContentProject");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageCategory", b =>
                {
                    b.Property<string>("Value")
                        .HasMaxLength(50);

                    b.Property<string>("PageEntityId")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.HasKey("Value", "PageEntityId");

                    b.HasIndex("PageEntityId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("Value");

                    b.ToTable("cs_PageCategory");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageComment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasMaxLength(255);

                    b.Property<string>("Content");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Ip")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("PageEntityId")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.Property<DateTime>("PubDate");

                    b.Property<string>("UserAgent")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PageEntityId");

                    b.HasIndex("ProjectId");

                    b.ToTable("cs_PageComment");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasMaxLength(255);

                    b.Property<string>("CategoriesCsv")
                        .HasMaxLength(500);

                    b.Property<string>("Content");

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<bool>("DisableEditor");

                    b.Property<string>("DraftAuthor")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent");

                    b.Property<DateTime?>("DraftPubDate");

                    b.Property<string>("DraftSerializedModel");

                    b.Property<string>("ExternalUrl")
                        .HasMaxLength(255);

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedByUser")
                        .HasMaxLength(100);

                    b.Property<string>("MenuFilters")
                        .HasMaxLength(500);

                    b.Property<bool>("MenuOnly")
                        .HasColumnType("bit");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(500);

                    b.Property<string>("MetaHtml");

                    b.Property<string>("MetaJson");

                    b.Property<int>("PageOrder");

                    b.Property<string>("ParentId")
                        .HasMaxLength(36);

                    b.Property<string>("ParentSlug")
                        .HasMaxLength(255);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.Property<DateTime?>("PubDate");

                    b.Property<string>("SerializedModel");

                    b.Property<string>("Serializer")
                        .HasMaxLength(50);

                    b.Property<bool>("ShowCategories")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowComments")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowHeading")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowLastModified")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowMenu")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowPubDate")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("TemplateKey")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ViewRoles");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationKey");

                    b.HasIndex("ParentId");

                    b.HasIndex("ProjectId");

                    b.ToTable("cs_Page");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageResourceEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Environment")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("PageEntityId")
                        .HasMaxLength(36);

                    b.Property<int>("Sort");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PageEntityId");

                    b.ToTable("cs_PageResource");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostCategory", b =>
                {
                    b.Property<string>("Value")
                        .HasMaxLength(50);

                    b.Property<string>("PostEntityId")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.HasKey("Value", "PostEntityId");

                    b.HasIndex("PostEntityId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("Value");

                    b.ToTable("cs_PostCategory");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostComment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasMaxLength(255);

                    b.Property<string>("Content");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Ip")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("PostEntityId")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.Property<DateTime>("PubDate");

                    b.Property<string>("UserAgent")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PostEntityId");

                    b.HasIndex("ProjectId");

                    b.ToTable("cs_PostComment");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasMaxLength(255);

                    b.Property<string>("AutoTeaser");

                    b.Property<string>("BlogId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.Property<string>("CategoriesCsv")
                        .HasMaxLength(500);

                    b.Property<string>("Content");

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DraftAuthor")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent");

                    b.Property<DateTime?>("DraftPubDate");

                    b.Property<string>("DraftSerializedModel");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250);

                    b.Property<bool>("IsFeatured");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedByUser")
                        .HasMaxLength(100);

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(500);

                    b.Property<string>("MetaHtml");

                    b.Property<string>("MetaJson");

                    b.Property<DateTime?>("PubDate");

                    b.Property<string>("SerializedModel");

                    b.Property<string>("Serializer")
                        .HasMaxLength(50);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("SuppressTeaser");

                    b.Property<string>("TeaserOverride");

                    b.Property<string>("TemplateKey")
                        .HasMaxLength(255);

                    b.Property<string>("ThumbnailUrl")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("CorrelationKey");

                    b.HasIndex("Slug");

                    b.ToTable("cs_Post");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageComment", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity")
                        .WithMany("PageComments")
                        .HasForeignKey("PageEntityId");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageResourceEntity", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity")
                        .WithMany("PageResources")
                        .HasForeignKey("PageEntityId");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostComment", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PostEntity")
                        .WithMany("PostComments")
                        .HasForeignKey("PostEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
