using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class TradeSaveContext : DbContext
    {
        public TradeSaveContext()
        {
        }

        public TradeSaveContext(DbContextOptions<TradeSaveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDetail> AccountDetails { get; set; }
        public virtual DbSet<AdminEmail> AdminEmails { get; set; }
        public virtual DbSet<AdminMarket> AdminMarkets { get; set; }
        public virtual DbSet<AllMarketLastDay> AllMarketLastDays { get; set; }
        public virtual DbSet<AppTradeLanguage> AppTradeLanguages { get; set; }
        public virtual DbSet<AppTradeTranslation> AppTradeTranslations { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<CustPotantional> CustPotantionals { get; set; }
        public virtual DbSet<DsMainMa> DsMainMas { get; set; }
        public virtual DbSet<Error> Errors { get; set; }
        public virtual DbSet<FPricesOldSignalInd> FPricesOldSignalInds { get; set; }
        public virtual DbSet<FSummery> FSummeries { get; set; }
        public virtual DbSet<FxEntryType> FxEntryTypes { get; set; }
        public virtual DbSet<FxOpenTrade> FxOpenTrades { get; set; }
        public virtual DbSet<FxPair> FxPairs { get; set; }
        public virtual DbSet<FxStrategy> FxStrategies { get; set; }
        public virtual DbSet<FxTimeFrame> FxTimeFrames { get; set; }
        public virtual DbSet<FxTradesMa> FxTradesMas { get; set; }
        public virtual DbSet<FxTradesMasVwLastTrade> FxTradesMasVwLastTrades { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<HomeRange1> HomeRange1s { get; set; }
        public virtual DbSet<HomeTk> HomeTks { get; set; }
        public virtual DbSet<IndexDic> IndexDics { get; set; }
        public virtual DbSet<IndexLastDaySignal> IndexLastDaySignals { get; set; }
        public virtual DbSet<IpCountry> IpCountries { get; set; }
        public virtual DbSet<LastDaySignal> LastDaySignals { get; set; }
        public virtual DbSet<LatestSuccessfulSignalsTrading> LatestSuccessfulSignalsTradings { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LogLog> LogLogs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MailConf> MailConfs { get; set; }
        public virtual DbSet<MailTxt> MailTxts { get; set; }
        public virtual DbSet<MainHome> MainHomes { get; set; }
        public virtual DbSet<MainRpt> MainRpts { get; set; }
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<MarketIndicator> MarketIndicators { get; set; }
        public virtual DbSet<MktInd> MktInds { get; set; }
        public virtual DbSet<MsEmailSysSetting> MsEmailSysSettings { get; set; }
        public virtual DbSet<MsMailDtl> MsMailDtls { get; set; }
        public virtual DbSet<MsMailMa> MsMailMas { get; set; }
        public virtual DbSet<NwDataMa> NwDataMas { get; set; }
        public virtual DbSet<NwDataMasRanking> NwDataMasRankings { get; set; }
        public virtual DbSet<NwExplanation> NwExplanations { get; set; }
        public virtual DbSet<NwNmDic> NwNmDics { get; set; }
        public virtual DbSet<NwSignalDic> NwSignalDics { get; set; }
        public virtual DbSet<NwSignalGrpMa> NwSignalGrpMas { get; set; }
        public virtual DbSet<NwSignalsTodayVw> NwSignalsTodayVws { get; set; }
        public virtual DbSet<NwTaDtl> NwTaDtls { get; set; }
        public virtual DbSet<NwTradesMa> NwTradesMas { get; set; }
        public virtual DbSet<NwTradesMasVw> NwTradesMasVws { get; set; }
        public virtual DbSet<NwTradesMasVw10> NwTradesMasVw10s { get; set; }
        public virtual DbSet<NwTradesMasVwOrginal> NwTradesMasVwOrginals { get; set; }
        public virtual DbSet<NwTradesMasVwOrginal1> NwTradesMasVwOrginal1s { get; set; }
        public virtual DbSet<NwTradingStraegiesMaster> NwTradingStraegiesMasters { get; set; }
        public virtual DbSet<NwTradingStrategiesGetTradesDtl> NwTradingStrategiesGetTradesDtls { get; set; }
        public virtual DbSet<NwTradingStrategiesMaster> NwTradingStrategiesMasters { get; set; }
        public virtual DbSet<PmNStreportTbl> PmNStreportTbls { get; set; }
        public virtual DbSet<PmStreportUvw> PmStreportUvws { get; set; }
        public virtual DbSet<PriceCom> PriceComs { get; set; }
        public virtual DbSet<PricesWeekly> PricesWeeklies { get; set; }
        public virtual DbSet<Qoute> Qoutes { get; set; }
        public virtual DbSet<ReportShortBuyMarketBasedStrategy> ReportShortBuyMarketBasedStrategies { get; set; }
        public virtual DbSet<ReportShortProfitMarketBasedStrategy> ReportShortProfitMarketBasedStrategies { get; set; }
        public virtual DbSet<SelectedTrade> SelectedTrades { get; set; }
        public virtual DbSet<SpMoneyManagment> SpMoneyManagments { get; set; }
        public virtual DbSet<SpMoneyManagmentNew> SpMoneyManagmentNews { get; set; }
        public virtual DbSet<SpMoneyManagmentNg> SpMoneyManagmentNgs { get; set; }
        public virtual DbSet<SpMoneyManagmentNgIndexPerformance> SpMoneyManagmentNgIndexPerformances { get; set; }
        public virtual DbSet<SpMoneyManagmentNgToSell> SpMoneyManagmentNgToSells { get; set; }
        public virtual DbSet<SpMoneyManagmentSum> SpMoneyManagmentSums { get; set; }
        public virtual DbSet<SpMoneyManagmentSumNew> SpMoneyManagmentSumNews { get; set; }
        public virtual DbSet<SpMoneyManagmentSumNg> SpMoneyManagmentSumNgs { get; set; }
        public virtual DbSet<SpMoneyManagmentSumNgSammaryView> SpMoneyManagmentSumNgSammaryViews { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<TickInfo> TickInfos { get; set; }
        public virtual DbSet<TrendDic> TrendDics { get; set; }
        public virtual DbSet<Up> Ups { get; set; }
        public virtual DbSet<Usergroup> Usergroups { get; set; }
        public virtual DbSet<WebMsg> WebMsgs { get; set; }
        public virtual DbSet<WillBeDeletedCustomer> WillBeDeletedCustomers { get; set; }
        public virtual DbSet<WillBeDeletedOrder> WillBeDeletedOrders { get; set; }
        public virtual DbSet<WillBeDeletedOrderDetail> WillBeDeletedOrderDetails { get; set; }
        public virtual DbSet<WillBeDeletedProduct> WillBeDeletedProducts { get; set; }
        public virtual DbSet<WillBeDeletedProductCategory> WillBeDeletedProductCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=TradeSave;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountDetail>(entity =>
            {
                entity.HasKey(e => e.TrkId);

                entity.ToTable("AccountDetail");

                entity.Property(e => e.TrkId).HasColumnName("trk_id");

                entity.Property(e => e.Conf).HasColumnName("conf");

                entity.Property(e => e.ConfgChgDate)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .HasColumnName("notes");

                entity.Property(e => e.PckgNo).HasColumnName("Pckg_no");

                entity.Property(e => e.PmntInfo).HasMaxLength(50);

                entity.Property(e => e.PmntType).HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ui).HasColumnName("UI");
            });

            modelBuilder.Entity<AdminEmail>(entity =>
            {
                entity.HasIndex(e => e.GroupId, "IX_AdminEmails_GroupId");

                entity.Property(e => e.Attachment).HasColumnName("attachment");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.TestMail).HasColumnName("testMail");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdminEmails)
                    .HasForeignKey(d => d.GroupId);
            });

            modelBuilder.Entity<AdminMarket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADMIN_MARKET");

                entity.HasIndex(e => new { e.Id, e.CntyId }, "UQ__ADMIN_MA__5D658A45397BCA41")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.CntyId }, "UQ__ADMIN_MA__5D658A45742BFC22")
                    .IsUnique();

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.CntyIde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CntyIDE");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dest)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dest");

                entity.Property(e => e.DestHost)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dtlt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DTLT");

                entity.Property(e => e.Dtlth)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DTLTH");

                entity.Property(e => e.ExName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EX_Name");

                entity.Property(e => e.Filet).HasColumnName("filet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_DESC");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.MktIde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MKT_IDE");
            });

            modelBuilder.Entity<AllMarketLastDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("All_MARKET_LAST_DAY");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtlt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DTLT");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Mt)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MT");
            });

            modelBuilder.Entity<AppTradeLanguage>(entity =>
            {
                entity.ToTable("AppTrade_Languages");

                entity.HasIndex(e => e.Code, "IX_AppTrade_Languages_Code");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<AppTradeTranslation>(entity =>
            {
                entity.ToTable("AppTrade_Translations");

                entity.HasIndex(e => e.LanguageId, "IX_AppTrade_Translations_LanguageId");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CustPotantional>(entity =>
            {
                entity.HasKey(e => e.CustMail)
                    .HasName("PK_Cust_Potantional_1");

                entity.ToTable("Cust_Potantional");

                entity.Property(e => e.CustMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cust_Mail");

                entity.Property(e => e.CustId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Cust_ID");

                entity.Property(e => e.MailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mail_ID");
            });

            modelBuilder.Entity<DsMainMa>(entity =>
            {
                entity.HasKey(e => e.TkId);

                entity.ToTable("DS_MAIN_MAS");

                entity.Property(e => e.TkId)
                    .ValueGeneratedNever()
                    .HasColumnName("TK_ID");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.TkNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TK_NM");

                entity.Property(e => e.TkSy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("TK_SY");
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.ToTable("ERRORS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Err)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("err");

                entity.Property(e => e.Func)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FPricesOldSignalInd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F_Prices_Old_Signal_Ind");

                entity.Property(e => e.DealPft).HasColumnName("Deal_Pft");

                entity.Property(e => e.DealPftPcnt).HasColumnName("Deal_Pft_Pcnt");

                entity.Property(e => e.Dt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dt");

                entity.Property(e => e.DtD)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("dtD");

                entity.Property(e => e.DtS)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dtS");

                entity.Property(e => e.Flg)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Mt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MT");

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nm");

                entity.Property(e => e.Tk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tk");
            });

            modelBuilder.Entity<FSummery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("F_summery");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DPft)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("D_Pft");

                entity.Property(e => e.DPftPct)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("D_Pft_Pct");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Mt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MT");

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nm");

                entity.Property(e => e.PerDeal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Per_deal");

                entity.Property(e => e.Stop).HasColumnName("stop");

                entity.Property(e => e.Tk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.TkProfit).HasColumnName("TK_Profit");
            });

            modelBuilder.Entity<FxEntryType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FX_Entry_Type");

                entity.Property(e => e.FxEntryTypeDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FX_Entry_Type_Desc");

                entity.Property(e => e.FxId).HasColumnName("FX_ID");
            });

            modelBuilder.Entity<FxOpenTrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FX_Open_Trade");

                entity.Property(e => e.EntryDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Entry_Date")
                    .IsFixedLength(true);

                entity.Property(e => e.EntryPrice).HasColumnName("Entry_Price");

                entity.Property(e => e.EntryTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Entry_Time")
                    .IsFixedLength(true);

                entity.Property(e => e.ExitDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Exit_Date")
                    .IsFixedLength(true);

                entity.Property(e => e.ExitPrice).HasColumnName("Exit_Price");

                entity.Property(e => e.ExitTime)
                    .HasMaxLength(10)
                    .HasColumnName("Exit_Time")
                    .IsFixedLength(true);

                entity.Property(e => e.FxEntryTypeDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FX_Entry_Type_Desc");

                entity.Property(e => e.FxId).HasColumnName("FX_ID");

                entity.Property(e => e.FxStrategyDetail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FX_Strategy_Detail");

                entity.Property(e => e.FxSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FX_Symbol");

                entity.Property(e => e.FxTimeFrame)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FX_TimeFrame");
            });

            modelBuilder.Entity<FxPair>(entity =>
            {
                entity.HasKey(e => e.FxId);

                entity.ToTable("FX_Pair");

                entity.Property(e => e.FxId)
                    .ValueGeneratedNever()
                    .HasColumnName("FX_ID");

                entity.Property(e => e.FxEnable).HasColumnName("FX_Enable");

                entity.Property(e => e.FxSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FX_Symbol");
            });

            modelBuilder.Entity<FxStrategy>(entity =>
            {
                entity.HasKey(e => e.FxId);

                entity.ToTable("FX_Strategy");

                entity.Property(e => e.FxId)
                    .ValueGeneratedNever()
                    .HasColumnName("FX_ID");

                entity.Property(e => e.FxStrategy1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FX_Strategy");

                entity.Property(e => e.FxStrategyDetail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FX_Strategy_Detail");
            });

            modelBuilder.Entity<FxTimeFrame>(entity =>
            {
                entity.HasKey(e => e.FxId);

                entity.ToTable("FX_TimeFrame");

                entity.Property(e => e.FxId)
                    .ValueGeneratedNever()
                    .HasColumnName("FX_ID");

                entity.Property(e => e.FxDefault).HasColumnName("Fx_Default");

                entity.Property(e => e.FxTimeFrame1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FX_TimeFrame");
            });

            modelBuilder.Entity<FxTradesMa>(entity =>
            {
                entity.HasKey(e => new { e.FxId, e.FxPairId, e.FxTimeFrameId, e.FxStrategyId, e.FxEntryTypeId });

                entity.ToTable("FX_Trades_Mas");

                entity.Property(e => e.FxId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FX_ID");

                entity.Property(e => e.FxPairId).HasColumnName("FX_Pair_ID");

                entity.Property(e => e.FxTimeFrameId).HasColumnName("FX_TimeFrame_ID");

                entity.Property(e => e.FxStrategyId).HasColumnName("FX_Strategy_ID");

                entity.Property(e => e.FxEntryTypeId).HasColumnName("FX_Entry_Type_ID");

                entity.Property(e => e.EntryDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Entry_Date")
                    .IsFixedLength(true);

                entity.Property(e => e.EntryPrice).HasColumnName("Entry_Price");

                entity.Property(e => e.EntryTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Entry_Time")
                    .IsFixedLength(true);

                entity.Property(e => e.ExitDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Exit_Date")
                    .IsFixedLength(true);

                entity.Property(e => e.ExitPrice).HasColumnName("Exit_Price");

                entity.Property(e => e.ExitTime)
                    .HasMaxLength(10)
                    .HasColumnName("Exit_Time")
                    .IsFixedLength(true);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Tp).HasColumnName("TP");
            });

            modelBuilder.Entity<FxTradesMasVwLastTrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FX_Trades_Mas_VW_LastTrade");

                entity.Property(e => e.EntryDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Entry_Date")
                    .IsFixedLength(true);

                entity.Property(e => e.EntryTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Entry_Time")
                    .IsFixedLength(true);

                entity.Property(e => e.FxPairId).HasColumnName("FX_Pair_ID");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");
            });

            modelBuilder.Entity<HomeRange1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Home_Range1");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.ORange)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("oRange");
            });

            modelBuilder.Entity<HomeTk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Home_tk");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DPftPct)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("D_Pft_Pct");

                entity.Property(e => e.DealPft).HasColumnName("Deal_Pft");

                entity.Property(e => e.DealPftPcnt).HasColumnName("Deal_Pft_Pcnt");

                entity.Property(e => e.Dt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dt");

                entity.Property(e => e.DtD)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("dtD");

                entity.Property(e => e.Flg)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_DESC");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nm");

                entity.Property(e => e.Tk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tk");
            });

            modelBuilder.Entity<IndexDic>(entity =>
            {
                entity.HasKey(e => e.IndexMkt)
                    .HasName("PK_Index_Dic_1");

                entity.ToTable("Index_Dic");

                entity.Property(e => e.IndexMkt).HasColumnName("Index_Mkt");

                entity.Property(e => e.IndexTick)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Index_Tick");
            });

            modelBuilder.Entity<IndexLastDaySignal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Index_Last_Day_Signal");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Flg)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Mt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MT");

                entity.Property(e => e.Nm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nm");
            });

            modelBuilder.Entity<IpCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IpCountry");

                entity.Property(e => e.CountryCode2)
                    .HasMaxLength(50)
                    .HasColumnName("COUNTRY_CODE2");

                entity.Property(e => e.CountryCode3)
                    .HasMaxLength(50)
                    .HasColumnName("COUNTRY_CODE3");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .HasColumnName("COUNTRY_NAME");

                entity.Property(e => e.IpFrom).HasColumnName("IP_FROM");

                entity.Property(e => e.IpTo).HasColumnName("IP_TO");
            });

            modelBuilder.Entity<LastDaySignal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LastDaySignals");

                entity.Property(e => e.DtDt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DT_Dt");

                entity.Property(e => e.DtMktId).HasColumnName("DT_MKT_ID");

                entity.Property(e => e.NmId).HasColumnName("NM_ID");

                entity.Property(e => e.NmMktId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NM_MKT_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Power)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.St)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ST");
            });

            modelBuilder.Entity<LatestSuccessfulSignalsTrading>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Latest_Successful_Signals_Trading");

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.DtDt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DT_Dt");

                entity.Property(e => e.DtMktId).HasColumnName("DT_MKT_ID");

                entity.Property(e => e.DtOpen).HasColumnName("DT_Open");

                entity.Property(e => e.NmEnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_EN_NAME");

                entity.Property(e => e.NmSymbol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.Power)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.St)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ST");

                entity.Property(e => e.Xpower)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("XPower");

                entity.Property(e => e.Xst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("XST");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Ui, e.MktId });

                entity.ToTable("LIST");

                entity.Property(e => e.Ui).HasColumnName("ui");

                entity.Property(e => e.MktId).HasColumnName("Mkt_id");

                entity.Property(e => e.Tk)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.TkSt)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tk_st");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Err)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("err");

                entity.Property(e => e.Func)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Log_Log");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.ConfgChgDate)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Lev).HasColumnName("lev");

                entity.Property(e => e.MDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_DESC");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mail");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PckgNo).HasColumnName("Pckg_No");

                entity.Property(e => e.PmntInfo).HasMaxLength(50);

                entity.Property(e => e.PmntType).HasMaxLength(50);

                entity.Property(e => e.SendMail).HasColumnName("Send_Mail");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrkId).HasColumnName("trk_id");

                entity.Property(e => e.Ui).HasColumnName("UI");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Serno);

                entity.ToTable("Login");

                entity.Property(e => e.Lev).HasColumnName("lev");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mail");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SendMail).HasColumnName("Send_Mail");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<MailConf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MailConf");

                entity.Property(e => e.Ldt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MT");
            });

            modelBuilder.Entity<MailTxt>(entity =>
            {
                entity.ToTable("mail_txt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Body)
                    .HasColumnType("ntext")
                    .HasColumnName("body");

                entity.Property(e => e.Footer)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("footer");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("header");

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<MainHome>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Main_Home");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_DESC");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Pct)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PerDeal).HasColumnName("Per_deal");
            });

            modelBuilder.Entity<MainRpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Main_Rpt");

                entity.Property(e => e.Chg).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Cl).HasColumnName("cl");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.CntyIde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CntyIDE");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DPft)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("D_Pft");

                entity.Property(e => e.DPftPct)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("D_Pft_Pct");

                entity.Property(e => e.DRec)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("D_REC");

                entity.Property(e => e.DRec1)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("d_rec1");

                entity.Property(e => e.DealPftPcnt).HasColumnName("Deal_Pft_Pcnt");

                entity.Property(e => e.Dt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dt");

                entity.Property(e => e.DtMd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dt_md");

                entity.Property(e => e.Dts)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dts");

                entity.Property(e => e.Flg)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FlgMd)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("flg_md");

                entity.Property(e => e.MedSwing)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MedSwingsg)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.MktIde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MKT_IDE");

                entity.Property(e => e.Mt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MT");

                entity.Property(e => e.Nm)
                    .HasMaxLength(100)
                    .HasColumnName("nm");

                entity.Property(e => e.Nm1)
                    .HasMaxLength(100)
                    .HasColumnName("nm1");

                entity.Property(e => e.Op).HasColumnName("op");

                entity.Property(e => e.PerDeal)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("Per_deal");

                entity.Property(e => e.PerDeal1)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("per_deal1");

                entity.Property(e => e.Polo)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("polo");

                entity.Property(e => e.Post).HasColumnName("post");

                entity.Property(e => e.PriceMd).HasColumnName("price_md");

                entity.Property(e => e.ProLos)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prolos1).HasColumnName("prolos1");

                entity.Property(e => e.Strength)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .HasColumnName("STRENGTH");

                entity.Property(e => e.Swing)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("swing");

                entity.Property(e => e.Tk)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.TkProfit)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("TK_Profit");

                entity.Property(e => e.Trend)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("trend");

                entity.Property(e => e.Val).HasColumnName("val");

                entity.Property(e => e.Vol).HasColumnName("vol");

                entity.Property(e => e.WRsisg).HasColumnName("W_RSISG");

                entity.Property(e => e.Xxxd).HasColumnName("XXXD");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CntyId });

                entity.ToTable("MARKET");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CntyId).HasColumnName("CntyID");

                entity.Property(e => e.CntyIde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CntyIDE");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dest)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dest");

                entity.Property(e => e.DestHost)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EX_Name");

                entity.Property(e => e.Filet).HasColumnName("filet");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_DESC");

                entity.Property(e => e.MktIde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MKT_IDE");

                entity.Property(e => e.Tk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tk");
            });

            modelBuilder.Entity<MarketIndicator>(entity =>
            {
                entity.HasKey(e => new { e.Tk, e.Dt, e.MktId });

                entity.ToTable("Market_Indicator");

                entity.Property(e => e.Tk)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.Dt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dt");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Cl).HasColumnName("cl");

                entity.Property(e => e.TrendIdFk).HasColumnName("Trend_Id_FK");
            });

            modelBuilder.Entity<MktInd>(entity =>
            {
                entity.HasKey(e => e.MktId);

                entity.ToTable("MktInd");

                entity.Property(e => e.MktId)
                    .ValueGeneratedNever()
                    .HasColumnName("MKT_ID");
            });

            modelBuilder.Entity<MsEmailSysSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MS_EMailSysSetting");

                entity.Property(e => e.SentDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Temp)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<MsMailDtl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MS_MAIL_DTL");

                entity.Property(e => e.SgId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SG_ID");

                entity.Property(e => e.SignAr).HasColumnName("Sign_Ar");

                entity.Property(e => e.SignEn).HasColumnName("Sign_En");

                entity.Property(e => e.SigntureArDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Signture_Ar_Desc");

                entity.Property(e => e.SigntureEnDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Signture_En_Desc");
            });

            modelBuilder.Entity<MsMailMa>(entity =>
            {
                entity.ToTable("MS_MAIL_MAS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArSgin).HasColumnName("Ar_Sgin");

                entity.Property(e => e.BodyAr)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("body_Ar");

                entity.Property(e => e.BodyEn)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("body_En");

                entity.Property(e => e.EnSgin).HasColumnName("En_Sgin");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Mkt).HasColumnName("MKT");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<NwDataMa>(entity =>
            {
                entity.HasKey(e => new { e.DtNmId, e.DtDt, e.DtMktId })
                    .HasName("PK__NW_Data___79F37231DCB90EF4");

                entity.ToTable("NW_Data_MAS");

                entity.Property(e => e.DtNmId).HasColumnName("DT_NM_ID");

                entity.Property(e => e.DtDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DT_Dt");

                entity.Property(e => e.DtMktId).HasColumnName("DT_MKT_ID");

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.DtHigh).HasColumnName("DT_High");

                entity.Property(e => e.DtLow).HasColumnName("DT_Low");

                entity.Property(e => e.DtNvalue).HasColumnName("DT_NValue");

                entity.Property(e => e.DtOpen).HasColumnName("DT_Open");

                entity.Property(e => e.DtValue).HasColumnName("DT_Value");

                entity.Property(e => e.DtVol).HasColumnName("DT_Vol");
            });

            modelBuilder.Entity<NwDataMasRanking>(entity =>
            {
                entity.HasKey(e => new { e.DtNmId, e.DtDt, e.DtMktId });

                entity.ToTable("NW_Data_MAS_Ranking");

                entity.Property(e => e.DtNmId).HasColumnName("DT_NM_ID");

                entity.Property(e => e.DtDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DT_Dt");

                entity.Property(e => e.DtMktId).HasColumnName("DT_MKT_ID");

                entity.Property(e => e.DtRank).HasColumnName("DT_Rank");

                entity.Property(e => e.DtRankLastDay).HasColumnName("DT_Rank_LastDay");

                entity.Property(e => e.DtRankQuickCross).HasColumnName("DT_Rank_Quick_Cross");
            });

            modelBuilder.Entity<NwExplanation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NW_Explanation");

                entity.Property(e => e.DtNvalue).HasColumnName("DT_NValue");

                entity.Property(e => e.DtValue).HasColumnName("DT_Value");

                entity.Property(e => e.PowerTrnd).HasMaxLength(74);

                entity.Property(e => e.ShortTerm).HasMaxLength(89);

                entity.Property(e => e.TrndCylDicTrend).HasMaxLength(12);

                entity.Property(e => e.Wave)
                    .HasMaxLength(70)
                    .HasColumnName("wave");
            });

            modelBuilder.Entity<NwNmDic>(entity =>
            {
                entity.HasKey(e => new { e.NmSymbol, e.NmMktId });

                entity.ToTable("NW_NM_DIC");

                entity.Property(e => e.NmSymbol)
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.NmMktId)
                    .HasMaxLength(10)
                    .HasColumnName("NM_MKT_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.NmArName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_AR_NAME");

                entity.Property(e => e.NmEnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_EN_NAME");

                entity.Property(e => e.NmId).HasColumnName("NM_ID");

                entity.Property(e => e.NmStopFlag)
                    .HasColumnName("NM_StopFlag")
                    .HasComment("Flag 0 means the Symbol is active");
            });

            modelBuilder.Entity<NwSignalDic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NW_signal_Dic");

                entity.Property(e => e.SgDescAr)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("SG_Desc_Ar");

                entity.Property(e => e.SgDescEn)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("SG_Desc_En");

                entity.Property(e => e.SgId).HasColumnName("SG_ID");
            });

            modelBuilder.Entity<NwSignalGrpMa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NW_SignalGrp_MAS");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.SgId).HasColumnName("SG_ID");

                entity.Property(e => e.Signal).HasColumnName("signal");
            });

            modelBuilder.Entity<NwSignalsTodayVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NW_Signals_Today_VW");

                entity.Property(e => e.MacdSg).HasColumnName("MacdSG");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Rsima).HasColumnName("RSIMA");

                entity.Property(e => e.SsdPost).HasColumnName("SSD_post");

                entity.Property(e => e.StochSg).HasColumnName("StochSG");

                entity.Property(e => e.TkId).HasColumnName("TK_ID");
            });

            modelBuilder.Entity<NwTaDtl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NW_TA_DTL");

                entity.Property(e => e.MktId).HasColumnName("Mkt_ID");
            });

            modelBuilder.Entity<NwTradesMa>(entity =>
            {
                entity.HasKey(e => new { e.TrNmId, e.Stdate, e.StyType })
                    .HasName("PK__NW_Trade__A7490AA10CDAE408");

                entity.ToTable("NW_Trades_Mas");

                entity.Property(e => e.TrNmId).HasColumnName("TR_NM_ID");

                entity.Property(e => e.Stdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StyType)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("1- Full Trend Stratgy for T Trend , from Data_Mas where [\"DT_Value\"].ToString().Substring(2, 1)= \r\n0,1,4,5 ");

                entity.Property(e => e.BuyPrice).HasColumnName("Buy_Price");

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MktTrend).HasColumnName("MKT_Trend");

                entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");

                entity.Property(e => e.TmMktId)
                    .HasColumnName("TM_Mkt_ID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.TradeId).HasColumnName("Trade_ID");
            });

            modelBuilder.Entity<NwTradesMasVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NW_Trades_Mas_VW");

                entity.Property(e => e.BuyPrice).HasColumnName("Buy_Price");

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.DtMktId).HasColumnName("DT_MKT_ID");

                entity.Property(e => e.DtNvalue).HasColumnName("DT_NValue");

                entity.Property(e => e.DtRank).HasColumnName("DT_Rank");

                entity.Property(e => e.DtRankLastDay).HasColumnName("DT_Rank_LastDay");

                entity.Property(e => e.DtRankQuickCross).HasColumnName("DT_Rank_Quick_Cross");

                entity.Property(e => e.DtValue).HasColumnName("DT_Value");

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MktTrend).HasColumnName("MKT_Trend");

                entity.Property(e => e.NmEnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_EN_NAME");

                entity.Property(e => e.NmSymbol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");

                entity.Property(e => e.Stdate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StyType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TrNmId).HasColumnName("TR_NM_ID");
            });

            modelBuilder.Entity<NwTradesMasVw10>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NW_Trades_Mas_VW10");

                entity.Property(e => e.BuyPrice).HasColumnName("Buy_Price");

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.DtRank).HasColumnName("DT_Rank");

                entity.Property(e => e.DtRankLastDay).HasColumnName("DT_Rank_LastDay");

                entity.Property(e => e.DtRankQuickCross).HasColumnName("DT_Rank_Quick_Cross");

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MktTrend).HasColumnName("MKT_Trend");

                entity.Property(e => e.NmEnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_EN_NAME");

                entity.Property(e => e.NmSymbol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");

                entity.Property(e => e.Stdate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StyType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TrNmId).HasColumnName("TR_NM_ID");
            });

            modelBuilder.Entity<NwTradesMasVwOrginal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NW_Trades_Mas_VW_Orginal");

                entity.Property(e => e.BuyPrice).HasColumnName("Buy_Price");

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MktTrend).HasColumnName("MKT_Trend");

                entity.Property(e => e.NmEnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_EN_NAME");

                entity.Property(e => e.NmSymbol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");

                entity.Property(e => e.Stdate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StyType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TrNmId).HasColumnName("TR_NM_ID");
            });

            modelBuilder.Entity<NwTradesMasVwOrginal1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NW_Trades_Mas_VW_Orginal1");

                entity.Property(e => e.BuyPrice).HasColumnName("Buy_Price");

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.DtRank).HasColumnName("DT_Rank");

                entity.Property(e => e.DtRankLastDay).HasColumnName("DT_Rank_LastDay");

                entity.Property(e => e.DtRankQuickCross).HasColumnName("DT_Rank_Quick_Cross");

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MktTrend).HasColumnName("MKT_Trend");

                entity.Property(e => e.NmEnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_EN_NAME");

                entity.Property(e => e.NmSymbol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");

                entity.Property(e => e.Stdate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StyType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TrNmId).HasColumnName("TR_NM_ID");
            });

            modelBuilder.Entity<NwTradingStraegiesMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NW_Trading_Straegies_Master");

                entity.Property(e => e.Annualreturn).HasColumnName("annualreturn");

                entity.Property(e => e.Drawdown)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("drawdown");

                entity.Property(e => e.MarketId).HasColumnName("Market_ID");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.MktTrend)
                    .IsUnicode(false)
                    .HasColumnName("Mkt_trend");

                entity.Property(e => e.PdivTo).HasColumnName("PDivTo");

                entity.Property(e => e.PercentageWinners).HasColumnName("Percentage_Winners");

                entity.Property(e => e.Sharpe)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sharpe");

                entity.Property(e => e.Signals).IsUnicode(false);

                entity.Property(e => e.StrategyId).HasColumnName("Strategy_ID");

                entity.Property(e => e.TotalPct).HasColumnName("TotalPCT");

                entity.Property(e => e.TradingSysNo).HasColumnName("TradingSys_No");

                entity.Property(e => e.TradingSysNo1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TradingSys_No1");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<NwTradingStrategiesGetTradesDtl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NW_Trading_Strategies_GetTrades_Dtl");

                entity.Property(e => e.CloseReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExitDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsClosed)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.IsLong)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MarketId).HasColumnName("Market_ID");

                entity.Property(e => e.Rank)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StrategyIdFk).HasColumnName("Strategy_ID_FK");

                entity.Property(e => e.SymbolId).HasColumnName("Symbol_ID");
            });

            modelBuilder.Entity<NwTradingStrategiesMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NW_Trading_Strategies_Master");

                entity.Property(e => e.DisableFlag)
                    .HasColumnName("Disable_Flag")
                    .HasComment("0 \\Disable - 1\\Enable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MarketId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Market_ID");

                entity.Property(e => e.PercentageWinners).HasColumnName("Percentage_Winners");

                entity.Property(e => e.SimulatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceAccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrategyDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Strategy_Description");

                entity.Property(e => e.StrategyId).HasColumnName("Strategy_ID");

                entity.Property(e => e.StrategyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Strategy_Name");

                entity.Property(e => e.StrategyVersionIdExpiryDate)
                    .HasMaxLength(10)
                    .HasColumnName("Strategy_Version_ID_Expiry_Date")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PmNStreportTbl>(entity =>
            {
                entity.HasKey(e => new { e.TdTk, e.TdStartDate, e.TdMktId });

                entity.ToTable("PM_N_STReport_Tbl");

                entity.Property(e => e.TdTk)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TD_tk");

                entity.Property(e => e.TdStartDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TD_StartDate");

                entity.Property(e => e.TdMktId).HasColumnName("TD_MKT_ID");

                entity.Property(e => e.CdCndRange)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cd_Cnd_Range");

                entity.Property(e => e.CdCndRule)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Cd_Cnd_Rule");

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("nm");

                entity.Property(e => e.Profit)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProfitPctPd)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Profit_PCT_PD")
                    .IsFixedLength(true);

                entity.Property(e => e.TdCl).HasColumnName("TD_Cl");

                entity.Property(e => e.TdDuration).HasColumnName("TD_Duration");

                entity.Property(e => e.TdEndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TD_EndDate");

                entity.Property(e => e.TdIndId).HasColumnName("TD_Ind_id");

                entity.Property(e => e.TdPrice).HasColumnName("TD_Price");

                entity.Property(e => e.TradePct).HasColumnName("Trade_PCT");

                entity.Property(e => e.Trend)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PmStreportUvw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PM_STReport_UVW");

                entity.Property(e => e.Adxrdiff).HasColumnName("adxrdiff");

                entity.Property(e => e.LiveTrendPower)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Live_Trend_Power");

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("nm");

                entity.Property(e => e.Profit)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProfitPctPd)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Profit_PCT_PD")
                    .IsFixedLength(true);

                entity.Property(e => e.TdCl).HasColumnName("TD_Cl");

                entity.Property(e => e.TdDuration).HasColumnName("TD_Duration");

                entity.Property(e => e.TdEndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TD_EndDate");

                entity.Property(e => e.TdMktId).HasColumnName("TD_MKT_ID");

                entity.Property(e => e.TdPrice).HasColumnName("TD_Price");

                entity.Property(e => e.TdStartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TD_StartDate");

                entity.Property(e => e.TdTk)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TD_tk");

                entity.Property(e => e.TodayCl).HasColumnName("Today_Cl");

                entity.Property(e => e.TradePct).HasColumnName("Trade_PCT");

                entity.Property(e => e.Trend)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TrendPower)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Trend_Power");
            });

            modelBuilder.Entity<PriceCom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PriceCom");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Mt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MT");

                entity.Property(e => e.PeriodType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Saved)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ser).ValueGeneratedOnAdd();

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<PricesWeekly>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prices_Weekly");

                entity.Property(e => e.Cl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cl");

                entity.Property(e => e.Dt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dt");

                entity.Property(e => e.Hi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hi");

                entity.Property(e => e.Lo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lo");

                entity.Property(e => e.MktId)
                    .HasMaxLength(10)
                    .HasColumnName("MKT_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nm");

                entity.Property(e => e.Op)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("op");

                entity.Property(e => e.Tk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.Vol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vol");
            });

            modelBuilder.Entity<Qoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Qoute");

                entity.Property(e => e.Change)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE");

                entity.Property(e => e.Changepct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEPCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Last)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportShortBuyMarketBasedStrategy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report_Short_Buy_Market_Based_Strategy");

                entity.Property(e => e.CycleTrend)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.DtMktId).HasColumnName("DT_MKT_ID");

                entity.Property(e => e.DtNvalue).HasColumnName("DT_NValue");

                entity.Property(e => e.DtValue).HasColumnName("DT_Value");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.NmArName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_AR_NAME");

                entity.Property(e => e.NmSymbol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.Power)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortInd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TasiPower)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TASI_Power");
            });

            modelBuilder.Entity<ReportShortProfitMarketBasedStrategy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report_Short_Profit_Market_Based_Strategy");

                entity.Property(e => e.CycleTrend)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DtClose).HasColumnName("DT_Close");

                entity.Property(e => e.DtMktId).HasColumnName("DT_MKT_ID");

                entity.Property(e => e.DtNvalue).HasColumnName("DT_NValue");

                entity.Property(e => e.DtOpen).HasColumnName("DT_Open");

                entity.Property(e => e.DtValue).HasColumnName("DT_Value");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.NmArName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_AR_NAME");

                entity.Property(e => e.NmSymbol)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NM_Symbol");

                entity.Property(e => e.Power)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Profit)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ShortInd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TasiPower)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TASI_Power");

                entity.Property(e => e.Wave)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SelectedTrade>(entity =>
            {
                entity.HasKey(e => new { e.Tk, e.LstSignalDt });

                entity.Property(e => e.Tk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.LstSignalDt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Advise)
                    .HasColumnType("ntext")
                    .HasColumnName("advise");

                entity.Property(e => e.MktId).HasColumnName("mkt_id");
            });

            modelBuilder.Entity<SpMoneyManagment>(entity =>
            {
                entity.HasKey(e => new { e.Tk, e.Stdate, e.Endate });

                entity.ToTable("SP_MoneyManagment");

                entity.Property(e => e.Tk)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.Stdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("stdate")
                    .IsFixedLength(true);

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("endate")
                    .IsFixedLength(true);

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasColumnName("nm");

                entity.Property(e => e.Profit).HasColumnName("profit");
            });

            modelBuilder.Entity<SpMoneyManagmentNew>(entity =>
            {
                entity.HasKey(e => new { e.Tk, e.Stdate, e.Endate });

                entity.ToTable("SP_MoneyManagment_New");

                entity.Property(e => e.Tk)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tk");

                entity.Property(e => e.Stdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("stdate")
                    .IsFixedLength(true);

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("endate")
                    .IsFixedLength(true);

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Nm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasColumnName("nm");

                entity.Property(e => e.Profit).HasColumnName("profit");
            });

            modelBuilder.Entity<SpMoneyManagmentNg>(entity =>
            {
                entity.HasKey(e => new { e.NmId, e.Stdate, e.TradingSysNo });

                entity.ToTable("SP_MoneyManagment_NG");

                entity.Property(e => e.NmId).HasColumnName("NM_ID");

                entity.Property(e => e.Stdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("stdate")
                    .IsFixedLength(true);

                entity.Property(e => e.TradingSysNo).HasColumnName("TradingSys_No");

                entity.Property(e => e.Endate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("endate")
                    .IsFixedLength(true);

                entity.Property(e => e.Endprice).HasColumnName("endprice");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Profit).HasColumnName("profit");

                entity.Property(e => e.RowId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RowID");

                entity.Property(e => e.Stprice).HasColumnName("stprice");
            });

            modelBuilder.Entity<SpMoneyManagmentNgIndexPerformance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SP_MoneyManagment_NG_Index_Performance");

                entity.Property(e => e.IndxNmId).HasColumnName("Indx_NM_ID");

                entity.Property(e => e.MktId).HasColumnName("Mkt_ID");
            });

            modelBuilder.Entity<SpMoneyManagmentNgToSell>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SP_MoneyManagment_NG_To_Sell");

                entity.Property(e => e.EndateMax)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("endate_Max")
                    .IsFixedLength(true);

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.TradingSysNo).HasColumnName("TradingSys_No");
            });

            modelBuilder.Entity<SpMoneyManagmentSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SP_MoneyManagment_Sum");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Stgy).IsUnicode(false);

                entity.Property(e => e.TotalPct).HasColumnName("TotalPCT");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SpMoneyManagmentSumNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SP_MoneyManagment_Sum_New");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.Stgy).IsUnicode(false);

                entity.Property(e => e.TotalPct).HasColumnName("TotalPCT");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SpMoneyManagmentSumNg>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.TradingSysNo });

                entity.ToTable("SP_MoneyManagment_Sum_NG");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TradingSysNo).HasColumnName("TradingSys_No");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.MktTrend)
                    .IsUnicode(false)
                    .HasColumnName("Mkt_trend");

                entity.Property(e => e.PdivTo).HasColumnName("PDivTo");

                entity.Property(e => e.Signals).IsUnicode(false);

                entity.Property(e => e.TotalPct).HasColumnName("TotalPCT");
            });

            modelBuilder.Entity<SpMoneyManagmentSumNgSammaryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SP_MoneyManagment_Sum_NG_Sammary_View");

                entity.Property(e => e.MktId).HasColumnName("MKT_ID");

                entity.Property(e => e.MktTrend)
                    .IsUnicode(false)
                    .HasColumnName("Mkt_trend");

                entity.Property(e => e.PdivTo).HasColumnName("PDivTo");

                entity.Property(e => e.Signals).IsUnicode(false);

                entity.Property(e => e.TotalPct).HasColumnName("TotalPCT");

                entity.Property(e => e.TradingSysNo).HasColumnName("TradingSys_No");

                entity.Property(e => e.TradingSysNo1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TradingSys_No1");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.Awwwqeqweqw)
                    .HasMaxLength(50)
                    .HasColumnName("awwwqeqweqw");
            });

            modelBuilder.Entity<TickInfo>(entity =>
            {
                entity.HasKey(e => e.TickId);

                entity.ToTable("Tick_Info");

                entity.Property(e => e.TickId).HasColumnName("Tick_ID");

                entity.Property(e => e.TickName)
                    .HasMaxLength(100)
                    .HasColumnName("Tick_Name");

                entity.Property(e => e.TickSymbol)
                    .HasMaxLength(30)
                    .HasColumnName("Tick_Symbol");
            });

            modelBuilder.Entity<TrendDic>(entity =>
            {
                entity.HasKey(e => e.TrendId);

                entity.ToTable("Trend_Dic");

                entity.Property(e => e.TrendId).HasColumnName("Trend_ID");

                entity.Property(e => e.TrendDesc)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Trend_Desc");
            });

            modelBuilder.Entity<Up>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("up");

                entity.Property(e => e.Up1).HasColumnName("up");
            });

            modelBuilder.Entity<WebMsg>(entity =>
            {
                entity.ToTable("WebMsg");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cmt)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("cmt");

                entity.Property(e => e.Flg).HasColumnName("flg");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mail");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Sub)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sub");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<WillBeDeletedCustomer>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_WillBeDeletedCustomers_Name");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<WillBeDeletedOrder>(entity =>
            {
                entity.HasIndex(e => e.CashierId, "IX_WillBeDeletedOrders_CashierId");

                entity.HasIndex(e => e.CustomerId, "IX_WillBeDeletedOrders_CustomerId");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.HasOne(d => d.Cashier)
                    .WithMany(p => p.WillBeDeletedOrders)
                    .HasForeignKey(d => d.CashierId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WillBeDeletedOrders)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<WillBeDeletedOrderDetail>(entity =>
            {
                entity.HasIndex(e => e.OrderId, "IX_WillBeDeletedOrderDetails_OrderId");

                entity.HasIndex(e => e.ProductId, "IX_WillBeDeletedOrderDetails_ProductId");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.WillBeDeletedOrderDetails)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WillBeDeletedOrderDetails)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<WillBeDeletedProduct>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_WillBeDeletedProducts_Name");

                entity.HasIndex(e => e.ParentId, "IX_WillBeDeletedProducts_ParentId");

                entity.HasIndex(e => e.ProductCategoryId, "IX_WillBeDeletedProducts_ProductCategoryId");

                entity.Property(e => e.BuyingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Icon)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.WillBeDeletedProducts)
                    .HasForeignKey(d => d.ProductCategoryId);
            });

            modelBuilder.Entity<WillBeDeletedProductCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
