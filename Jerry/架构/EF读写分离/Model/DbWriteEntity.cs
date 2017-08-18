namespace EF读写分离.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbWriteEntity : DbContext
    {
        public DbWriteEntity()
            : base("name=DbWriteEntity")
        {
        }

        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleOperation> ModuleOperations { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserModule> UserModules { get; set; }
        public virtual DbSet<ChainMarketing> ChainMarketings { get; set; }
        public virtual DbSet<ChainMarketingSend> ChainMarketingSends { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AdminManageUser> AdminManageUsers { get; set; }
        public virtual DbSet<AdminUserModule> AdminUserModules { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentChainCheckMsg> AgentChainCheckMsgs { get; set; }
        public virtual DbSet<AgentCommissionRatio> AgentCommissionRatios { get; set; }
        public virtual DbSet<AgentInCity> AgentInCities { get; set; }
        public virtual DbSet<AgentInCityInProduct> AgentInCityInProducts { get; set; }
        public virtual DbSet<AgentInRestaurant> AgentInRestaurants { get; set; }
        public virtual DbSet<AgentInRestaurantRejectedRecord> AgentInRestaurantRejectedRecords { get; set; }
        public virtual DbSet<AgentReasonForRejection> AgentReasonForRejections { get; set; }
        public virtual DbSet<AnalysisBusinessTemporarydata> AnalysisBusinessTemporarydatas { get; set; }
        public virtual DbSet<AnalysisBusinessTemporaryTask> AnalysisBusinessTemporaryTasks { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<AuthTokenControlCenter> AuthTokenControlCenters { get; set; }
        public virtual DbSet<BaiDuMapping> BaiDuMappings { get; set; }
        public virtual DbSet<BaseSiteSetting> BaseSiteSettings { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CityBusinessDistrict> CityBusinessDistricts { get; set; }
        public virtual DbSet<CityLandMark> CityLandMarks { get; set; }
        public virtual DbSet<CityOrderBrokerage> CityOrderBrokerages { get; set; }
        public virtual DbSet<CommErrorLog> CommErrorLogs { get; set; }
        public virtual DbSet<Cuisine> Cuisines { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAliasClassification> CustomerAliasClassifications { get; set; }
        public virtual DbSet<CustomerAliasClassificationInRestaurantRFM> CustomerAliasClassificationInRestaurantRFMs { get; set; }
        public virtual DbSet<CustomerAnniversary> CustomerAnniversaries { get; set; }
        public virtual DbSet<CustomerAnniversaryClassification> CustomerAnniversaryClassifications { get; set; }
        public virtual DbSet<CustomerAppellation> CustomerAppellations { get; set; }
        public virtual DbSet<CustomerAssginStat> CustomerAssginStats { get; set; }
        public virtual DbSet<CustomerAssginStatLog> CustomerAssginStatLogs { get; set; }
        public virtual DbSet<CustomerBadRecord> CustomerBadRecords { get; set; }
        public virtual DbSet<CustomerClassWithRFM> CustomerClassWithRFMs { get; set; }
        public virtual DbSet<CustomerDisease> CustomerDiseases { get; set; }
        public virtual DbSet<CustomerInfoChange> CustomerInfoChanges { get; set; }
        public virtual DbSet<CustomerMemo> CustomerMemoes { get; set; }
        public virtual DbSet<CustomerMemorandum> CustomerMemorandums { get; set; }
        public virtual DbSet<CustomerMerge> CustomerMerges { get; set; }
        public virtual DbSet<CustomerMergeLog> CustomerMergeLogs { get; set; }
        public virtual DbSet<CustomerMultipleCount> CustomerMultipleCounts { get; set; }
        public virtual DbSet<CustomerNote> CustomerNotes { get; set; }
        public virtual DbSet<CustomerSurvey> CustomerSurveys { get; set; }
        public virtual DbSet<CustomerSurveyClassification> CustomerSurveyClassifications { get; set; }
        public virtual DbSet<CustomerTag> CustomerTags { get; set; }
        public virtual DbSet<CustomerTagClickLog> CustomerTagClickLogs { get; set; }
        public virtual DbSet<Deskcommission> Deskcommissions { get; set; }
        public virtual DbSet<DicData> DicDatas { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DstVirtualNum> DstVirtualNums { get; set; }
        public virtual DbSet<ExtChannel> ExtChannels { get; set; }
        public virtual DbSet<ExtChannelCity> ExtChannelCities { get; set; }
        public virtual DbSet<ExtChannelDayStat> ExtChannelDayStats { get; set; }
        public virtual DbSet<ExtChannelMonthStat> ExtChannelMonthStats { get; set; }
        public virtual DbSet<ExtChannelPhone> ExtChannelPhones { get; set; }
        public virtual DbSet<ImportDataTemp> ImportDataTemps { get; set; }
        public virtual DbSet<ManualTopUpLog> ManualTopUpLogs { get; set; }
        public virtual DbSet<Marketing> Marketings { get; set; }
        public virtual DbSet<MarketingClassification> MarketingClassifications { get; set; }
        public virtual DbSet<MarketingCount> MarketingCounts { get; set; }
        public virtual DbSet<MarketingOrdination> MarketingOrdinations { get; set; }
        public virtual DbSet<MarketingToCustomer> MarketingToCustomers { get; set; }
        public virtual DbSet<MarketingToCustomerToOrder> MarketingToCustomerToOrders { get; set; }
        public virtual DbSet<MarketingToRestaurant> MarketingToRestaurants { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDesk> OrderDesks { get; set; }
        public virtual DbSet<OrderDeskUpdateAmount> OrderDeskUpdateAmounts { get; set; }
        public virtual DbSet<OrderInLabel> OrderInLabels { get; set; }
        public virtual DbSet<OrderInMarketing> OrderInMarketings { get; set; }
        public virtual DbSet<OrderOtherPayRecord> OrderOtherPayRecords { get; set; }
        public virtual DbSet<OrderPersonalized> OrderPersonalizeds { get; set; }
        public virtual DbSet<OrderPersonalizedPic> OrderPersonalizedPics { get; set; }
        public virtual DbSet<OrderRemarkLabel> OrderRemarkLabels { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<PhoneQuit> PhoneQuits { get; set; }
        public virtual DbSet<PhoneReserve> PhoneReserves { get; set; }
        public virtual DbSet<PhoneReserveArchive> PhoneReserveArchives { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCommissionRatio> ProductCommissionRatios { get; set; }
        public virtual DbSet<RecordOpenOrderError> RecordOpenOrderErrors { get; set; }
        public virtual DbSet<ResCuisine> ResCuisines { get; set; }
        public virtual DbSet<ReserveOrder> ReserveOrders { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<RestaurantAdditionalRecording> RestaurantAdditionalRecordings { get; set; }
        public virtual DbSet<RestaurantArea> RestaurantAreas { get; set; }
        public virtual DbSet<RestaurantAreaDesk> RestaurantAreaDesks { get; set; }
        public virtual DbSet<RestaurantAreaDeskChildren> RestaurantAreaDeskChildrens { get; set; }
        public virtual DbSet<RestaurantAreaDeskClassification> RestaurantAreaDeskClassifications { get; set; }
        public virtual DbSet<RestaurantAreaDeskCost> RestaurantAreaDeskCosts { get; set; }
        public virtual DbSet<RestaurantAreaDeskFacility> RestaurantAreaDeskFacilities { get; set; }
        public virtual DbSet<RestaurantAreaDeskInRestaurantAreaDeskCost> RestaurantAreaDeskInRestaurantAreaDeskCosts { get; set; }
        public virtual DbSet<RestaurantAreaDeskPic> RestaurantAreaDeskPics { get; set; }
        public virtual DbSet<RestaurantAreaDeskRelation> RestaurantAreaDeskRelations { get; set; }
        public virtual DbSet<RestaurantAreaDeskRelationDetail> RestaurantAreaDeskRelationDetails { get; set; }
        public virtual DbSet<RestaurantAreaStatisticsSet> RestaurantAreaStatisticsSets { get; set; }
        public virtual DbSet<RestaurantBanquet> RestaurantBanquets { get; set; }
        public virtual DbSet<RestaurantBasicInfo> RestaurantBasicInfoes { get; set; }
        public virtual DbSet<RestaurantBasicInfoI> RestaurantBasicInfoIs { get; set; }
        public virtual DbSet<RestaurantClassification> RestaurantClassifications { get; set; }
        public virtual DbSet<RestaurantCustomerAutomaticClassification> RestaurantCustomerAutomaticClassifications { get; set; }
        public virtual DbSet<RestaurantCXJDeskInfo> RestaurantCXJDeskInfoes { get; set; }
        public virtual DbSet<RestaurantDiscountRight> RestaurantDiscountRights { get; set; }
        public virtual DbSet<RestaurantDiscount> RestaurantDiscounts { get; set; }
        public virtual DbSet<RestaurantFinanceClassification> RestaurantFinanceClassifications { get; set; }
        public virtual DbSet<RestaurantInvoice> RestaurantInvoices { get; set; }
        public virtual DbSet<RestaurantLicense> RestaurantLicenses { get; set; }
        public virtual DbSet<RestaurantMealsTime> RestaurantMealsTimes { get; set; }
        public virtual DbSet<RestaurantMealsTimeClassification> RestaurantMealsTimeClassifications { get; set; }
        public virtual DbSet<RestaurantMealsTimeClassificationInTime> RestaurantMealsTimeClassificationInTimes { get; set; }
        public virtual DbSet<RestaurantOperaSetting> RestaurantOperaSettings { get; set; }
        public virtual DbSet<RestaurantOrderDeskCount> RestaurantOrderDeskCounts { get; set; }
        public virtual DbSet<RestaurantPhone> RestaurantPhones { get; set; }
        public virtual DbSet<RestaurantProduct> RestaurantProducts { get; set; }
        public virtual DbSet<RestaurantRFM> RestaurantRFMs { get; set; }
        public virtual DbSet<RestaurantRFMClassification> RestaurantRFMClassifications { get; set; }
        public virtual DbSet<RestaurantRFMverage> RestaurantRFMverages { get; set; }
        public virtual DbSet<RestaurantSMSRoute> RestaurantSMSRoutes { get; set; }
        public virtual DbSet<RestaurantSmsTemplate> RestaurantSmsTemplates { get; set; }
        public virtual DbSet<RestaurantTotalDetail> RestaurantTotalDetails { get; set; }
        public virtual DbSet<RestaurantUser> RestaurantUsers { get; set; }
        public virtual DbSet<RestaurantUserAreaRight> RestaurantUserAreaRights { get; set; }
        public virtual DbSet<RestaurantUserAreaSaleRight> RestaurantUserAreaSaleRights { get; set; }
        public virtual DbSet<RestaurantUserComeTelRight> RestaurantUserComeTelRights { get; set; }
        public virtual DbSet<RestaurantWorthClassification> RestaurantWorthClassifications { get; set; }
        public virtual DbSet<SmsPrice> SmsPrices { get; set; }
        public virtual DbSet<SmsSendStateRecord> SmsSendStateRecords { get; set; }
        public virtual DbSet<SmsTemplateParameter> SmsTemplateParameters { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<T_BillNo> T_BillNo { get; set; }
        public virtual DbSet<t_Charge_Info> t_Charge_Info { get; set; }
        public virtual DbSet<T_Finance_Detail> T_Finance_Detail { get; set; }
        public virtual DbSet<T_InCome_Detail> T_InCome_Detail { get; set; }
        public virtual DbSet<T_Pay_Detail> T_Pay_Detail { get; set; }
        public virtual DbSet<T_SendSMS> T_SendSMS { get; set; }
        public virtual DbSet<T_SmsTask> T_SmsTask { get; set; }
        public virtual DbSet<T_Stat_ActiveMemberValue> T_Stat_ActiveMemberValue { get; set; }
        public virtual DbSet<T_Stat_Channel_Detail> T_Stat_Channel_Detail { get; set; }
        public virtual DbSet<T_Stat_Channel_Head> T_Stat_Channel_Head { get; set; }
        public virtual DbSet<T_Stat_ChannelResource_Total> T_Stat_ChannelResource_Total { get; set; }
        public virtual DbSet<T_Stat_CustomerClass> T_Stat_CustomerClass { get; set; }
        public virtual DbSet<T_Stat_CustomerOrder_Detail> T_Stat_CustomerOrder_Detail { get; set; }
        public virtual DbSet<T_Stat_CustomerOrderStatus> T_Stat_CustomerOrderStatus { get; set; }
        public virtual DbSet<T_Stat_CustomerStatus> T_Stat_CustomerStatus { get; set; }
        public virtual DbSet<T_Stat_CustomerStatus_StatusHistory> T_Stat_CustomerStatus_StatusHistory { get; set; }
        public virtual DbSet<T_Stat_Detail> T_Stat_Detail { get; set; }
        public virtual DbSet<T_Stat_DZUser_TotalConsumption> T_Stat_DZUser_TotalConsumption { get; set; }
        public virtual DbSet<T_Stat_Head> T_Stat_Head { get; set; }
        public virtual DbSet<T_Stat_Marketing_Detail> T_Stat_Marketing_Detail { get; set; }
        public virtual DbSet<T_Stat_Marketing_Head> T_Stat_Marketing_Head { get; set; }
        public virtual DbSet<T_Stat_Order_Detail> T_Stat_Order_Detail { get; set; }
        public virtual DbSet<T_Stat_Order_Head> T_Stat_Order_Head { get; set; }
        public virtual DbSet<T_Stat_Restaurant_Total> T_Stat_Restaurant_Total { get; set; }
        public virtual DbSet<T_Withdraw_Detail> T_Withdraw_Detail { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserInAgent> UserInAgents { get; set; }
        public virtual DbSet<UserInChain> UserInChains { get; set; }
        public virtual DbSet<UserInCustomerClassification> UserInCustomerClassifications { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public virtual DbSet<UserOperateLog> UserOperateLogs { get; set; }
        public virtual DbSet<UserPhone> UserPhones { get; set; }
        public virtual DbSet<UserQuit> UserQuits { get; set; }
        public virtual DbSet<UserSetting> UserSettings { get; set; }
        public virtual DbSet<ConversationStatu> ConversationStatus { get; set; }
        public virtual DbSet<DstVirtualNumInfo> DstVirtualNumInfoes { get; set; }
        public virtual DbSet<DZFeedback> DZFeedbacks { get; set; }
        public virtual DbSet<DZUserInfo> DZUserInfoes { get; set; }
        public virtual DbSet<SoundRecording> SoundRecordings { get; set; }
        public virtual DbSet<TelOrder> TelOrders { get; set; }
        public virtual DbSet<WXDZUser> WXDZUsers { get; set; }
        public virtual DbSet<WXDZUserShareLog> WXDZUserShareLogs { get; set; }
        public virtual DbSet<RestaurantOpen> RestaurantOpens { get; set; }
        public virtual DbSet<UserReportSetting> UserReportSettings { get; set; }
        public virtual DbSet<CreditChangeLog> CreditChangeLogs { get; set; }
        public virtual DbSet<CustomerCredit> CustomerCredits { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialClassification> MaterialClassifications { get; set; }
        public virtual DbSet<MessageNotice> MessageNotices { get; set; }
        public virtual DbSet<PhoneValidCode> PhoneValidCodes { get; set; }
        public virtual DbSet<QrCode> QrCodes { get; set; }
        public virtual DbSet<QrCodeLog> QrCodeLogs { get; set; }
        public virtual DbSet<QrCodeStat> QrCodeStats { get; set; }
        public virtual DbSet<ResReply> ResReplies { get; set; }
        public virtual DbSet<WXBirthdayMarkingSend> WXBirthdayMarkingSends { get; set; }
        public virtual DbSet<WXCustomer> WXCustomers { get; set; }
        public virtual DbSet<WXCustomerRelation> WXCustomerRelations { get; set; }
        public virtual DbSet<WXMarkingSend> WXMarkingSends { get; set; }
        public virtual DbSet<WXPublicAccount> WXPublicAccounts { get; set; }
        public virtual DbSet<WXRe> WXRes { get; set; }
        public virtual DbSet<WXUser> WXUsers { get; set; }
        public virtual DbSet<WXUserSendRecord> WXUserSendRecords { get; set; }
        public virtual DbSet<LunisolarData> LunisolarDatas { get; set; }
        //public virtual DbSet<MarketingToCustomer_bak> MarketingToCustomer_bak { get; set; }
        //public virtual DbSet<Order_bak> Order_bak { get; set; }
        //public virtual DbSet<OrderDesk_bak> OrderDesk_bak { get; set; }
        //public virtual DbSet<PhoneReserve_bak> PhoneReserve_bak { get; set; }
        //public virtual DbSet<RestaurantOrderDeskCount_bak> RestaurantOrderDeskCount_bak { get; set; }
        //public virtual DbSet<T_Stat_Channel_Detail_20161122bak> T_Stat_Channel_Detail_20161122bak { get; set; }
        //public virtual DbSet<T_Stat_Channel_Detail_bak> T_Stat_Channel_Detail_bak { get; set; }
        //public virtual DbSet<UserOperateLog_bak> UserOperateLog_bak { get; set; }
        public virtual DbSet<DZUserOrder> DZUserOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Module>()
                .HasMany(e => e.ModuleOperations)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.UserModules)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Pages)
                .WithMany(e => e.Modules)
                .Map(m => m.ToTable("ModulePage", "Authorization").MapLeftKey("ModuleId").MapRightKey("PageId"));

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Modules)
                .Map(m => m.ToTable("ProductModule", "Authorization").MapLeftKey("ModuleId").MapRightKey("ProductID"));

            modelBuilder.Entity<Module>()
                .HasMany(e => e.UserGroups)
                .WithMany(e => e.Modules)
                .Map(m => m.ToTable("UserGroupModule", "Authorization").MapLeftKey("ModuleId").MapRightKey("GroupType"));

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.ModuleOperations)
                .WithRequired(e => e.Operation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Page>()
                .HasMany(e => e.ModuleOperations)
                .WithRequired(e => e.Page)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChainMarketing>()
                .HasOptional(e => e.ChainMarketingSend)
                .WithRequired(e => e.ChainMarketing);

            modelBuilder.Entity<Address>()
                .Property(e => e.AddressInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CompanyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.OpeningAnAccountProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.OpeningAnAccountCity)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.OpeningAnAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Payee)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentCommissionRatios)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentInCities)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentInRestaurants)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentInRestaurantRejectedRecords)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AgentChainCheckMsg>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<AgentChainCheckMsg>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<AgentChainCheckMsg>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<AgentChainCheckMsg>()
                .Property(e => e.RestaurantName)
                .IsUnicode(false);

            modelBuilder.Entity<AgentChainCheckMsg>()
                .Property(e => e.SpMemo)
                .IsUnicode(false);

            modelBuilder.Entity<AgentInRestaurantRejectedRecord>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<AgentReasonForRejection>()
                .Property(e => e.AgentReasonForRejectionContent)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .Property(e => e.ApplicationName)
                .IsUnicode(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.Modules)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Applications)
                .Map(m => m.ToTable("UserInApplication").MapLeftKey("ApplicationID").MapRightKey("UserGuid"));

            modelBuilder.Entity<AuthTokenControlCenter>()
                .Property(e => e.Appid)
                .IsUnicode(false);

            modelBuilder.Entity<AuthTokenControlCenter>()
                .Property(e => e.Secretid)
                .IsUnicode(false);

            modelBuilder.Entity<AuthTokenControlCenter>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<AuthTokenControlCenter>()
                .Property(e => e.RefreshToken)
                .IsUnicode(false);

            modelBuilder.Entity<BaiDuMapping>()
                .Property(e => e.channelId)
                .IsUnicode(false);

            modelBuilder.Entity<BaseSiteSetting>()
                .Property(e => e.KeyWord)
                .IsUnicode(false);

            modelBuilder.Entity<BaseSiteSetting>()
                .Property(e => e.KeyValue)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.AgentCommissionRatios)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.AgentInCities)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.CityBusinessDistricts)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.CityLandMarks)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.CityOrderBrokerages)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.t_Charge_Info)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CityBusinessDistrict>()
                .Property(e => e.CityBusinessDistrictName)
                .IsUnicode(false);

            modelBuilder.Entity<CityBusinessDistrict>()
                .Property(e => e.X)
                .IsUnicode(false);

            modelBuilder.Entity<CityBusinessDistrict>()
                .Property(e => e.Y)
                .IsUnicode(false);

            modelBuilder.Entity<CityBusinessDistrict>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<CityBusinessDistrict>()
                .HasMany(e => e.Restaurants)
                .WithMany(e => e.CityBusinessDistricts)
                .Map(m => m.ToTable("RestaurantInCityBusinessDistrict").MapLeftKey("CityBusinessDistrictID").MapRightKey("RestaurantGuid"));

            modelBuilder.Entity<CityLandMark>()
                .Property(e => e.X)
                .IsUnicode(false);

            modelBuilder.Entity<CityLandMark>()
                .Property(e => e.Y)
                .IsUnicode(false);

            modelBuilder.Entity<CityLandMark>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<CityOrderBrokerage>()
                .Property(e => e.OrderBrokerage)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Cuisine>()
                .HasMany(e => e.ResCuisines)
                .WithRequired(e => e.Cuisine)
                .HasForeignKey(e => e.CuisineLevel2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuisine>()
                .HasMany(e => e.ResCuisines1)
                .WithRequired(e => e.Cuisine1)
                .HasForeignKey(e => e.CuisineLevel1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CanNotEat)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.MonetaryValueExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.MonetaryValueAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ActiveMonetaryValueExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ActiveMonetaryValueAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ActiveDeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ActiveSpendAbility)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstLetter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PointsMoney)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ChargeMoney)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerBadRecords)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerID);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerDiseases)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.CustomerMultipleCount)
                .WithRequired(e => e.Customer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerSurveys)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerTags)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.MarketingToCustomers)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Phones)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ReserveOrders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerAliasClassification>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAliasClassification>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.CustomerAliasClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerAliasClassification>()
                .HasMany(e => e.CustomerAliasClassificationInRestaurantRFMs)
                .WithRequired(e => e.CustomerAliasClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerBadRecord>()
                .Property(e => e.BadRecord)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerMemorandum>()
                .Property(e => e.ContentInfo)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerMultipleCount>()
                .Property(e => e.Amont)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CustomerSurveyClassification>()
                .Property(e => e.CustomerSurveyClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerSurveyClassification>()
                .HasMany(e => e.CustomerSurveys)
                .WithRequired(e => e.CustomerSurveyClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerSurveyClassification>()
                .HasMany(e => e.CustomerSurveyClassification1)
                .WithOptional(e => e.CustomerSurveyClassification2)
                .HasForeignKey(e => e.ParentGuid);

            modelBuilder.Entity<CustomerTag>()
                .Property(e => e.TagName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerTag>()
                .HasMany(e => e.CustomerTagClickLogs)
                .WithRequired(e => e.CustomerTag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Deskcommission>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<Deskcommission>()
                .Property(e => e.RestaurantName)
                .IsUnicode(false);

            modelBuilder.Entity<Deskcommission>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Deskcommission>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Disease>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Disease>()
                .HasMany(e => e.CustomerDiseases)
                .WithRequired(e => e.Disease)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DstVirtualNum>()
                .Property(e => e.DstVirtualNum1)
                .IsUnicode(false);

            modelBuilder.Entity<ExtChannel>()
                .HasMany(e => e.ExtChannelPhones)
                .WithRequired(e => e.ExtChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExtChannel>()
                .HasMany(e => e.ExtChannelCities)
                .WithRequired(e => e.ExtChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ImportDataTemp>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ManualTopUpLog>()
                .Property(e => e.AmountCollected)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.MarketingTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.MarketingClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.RestaurantName)
                .IsUnicode(false);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.AuditUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.Responseivity)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.LoadExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.LoadAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.LoadOrderOfFrequency)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.LoadRecentDiningTime)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.RunningExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.RunningAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.RunningOrderOfFrequency)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.RunningRecentDiningTime)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.PromoteExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.PromoteAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.PromoteOrderOfFrequency)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .Property(e => e.PromoteRecentDiningTime)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Marketing>()
                .HasMany(e => e.MarketingToCustomers)
                .WithRequired(e => e.Marketing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marketing>()
                .HasMany(e => e.OrderInMarketings)
                .WithRequired(e => e.Marketing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marketing>()
                .HasMany(e => e.SmsSendStateRecords)
                .WithRequired(e => e.Marketing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingClassification>()
                .Property(e => e.MarketingClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingClassification>()
                .HasMany(e => e.MarketingCounts)
                .WithRequired(e => e.MarketingClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingCount>()
                .Property(e => e.CoverCrowd)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingCount>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MarketingOrdination>()
                .Property(e => e.RFMClassifiyIds)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingOrdination>()
                .Property(e => e.CustomerAliasClassificationIds)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingOrdination>()
                .Property(e => e.UserChannelOrdination)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingToCustomer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingToCustomer>()
                .Property(e => e.LoadExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MarketingToCustomer>()
                .Property(e => e.LoadAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MarketingToCustomer>()
                .Property(e => e.LoadOrderOfFrequency)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MarketingToCustomer>()
                .Property(e => e.LoadRecentDiningTime)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.Requirement)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Deposit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.UserOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.AggregateAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDesks)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderInMarketings)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.ProfitRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk>()
                .Property(e => e.ExchangeTableUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderPersonalized>()
                .Property(e => e.Theme)
                .IsUnicode(false);

            modelBuilder.Entity<OrderPersonalized>()
                .Property(e => e.CustomNum)
                .IsUnicode(false);

            modelBuilder.Entity<OrderPersonalized>()
                .Property(e => e.Sandtable)
                .IsUnicode(false);

            modelBuilder.Entity<OrderPersonalized>()
                .Property(e => e.WelcomeScreen)
                .IsUnicode(false);

            modelBuilder.Entity<OrderPersonalizedPic>()
                .Property(e => e.ResourcePath)
                .IsUnicode(false);

            modelBuilder.Entity<Phone>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductCommissionRatios)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.RestaurantProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.t_Charge_Info)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ChargeItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordOpenOrderError>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<RecordOpenOrderError>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<RecordOpenOrderError>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<RecordOpenOrderError>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<RecordOpenOrderError>()
                .Property(e => e.Mealtime)
                .IsUnicode(false);

            modelBuilder.Entity<RecordOpenOrderError>()
                .Property(e => e.PeriodName)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.RestaurantName)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.CommissionsAndDiscounts)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.AllOrderNum)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.MonetaryValueExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.MonetaryValueAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.AgentInRestaurantRejectedRecords)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.CustomerAliasClassifications)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.CustomerAliasClassificationInRestaurantRFMs)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.CustomerBadRecords)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.OrderRemarkLabels)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Phones)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.ResCuisines)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.ReserveOrders)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.MaterialClassifications)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Materials)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.QrCodes)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.QrCodeLogs)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.QrCodeStats)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantUsers)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantPhones)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasOptional(e => e.RestaurantOpen)
                .WithRequired(e => e.Restaurant);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantAreas)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantAreaDesks)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantCustomerAutomaticClassifications)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasOptional(e => e.RestaurantLicense)
                .WithRequired(e => e.Restaurant);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantMealsTimes)
                .WithOptional(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantProducts)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasOptional(e => e.RestaurantRFMverage)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.SmsSendStateRecords)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.UserLoginLogs)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.UserQuits)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantClassifications)
                .WithMany(e => e.Restaurants)
                .Map(m => m.ToTable("RestaurantInRestaurantClassification").MapLeftKey("RestaurantGuid").MapRightKey("RestaurantClassificationId"));

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantMealsTimeClassifications)
                .WithMany(e => e.Restaurants)
                .Map(m => m.ToTable("RestaurantInRestaurantMealsTimeClassification").MapLeftKey("RestaurantGuid").MapRightKey("RestaurantMealsTimeClassificationID"));

            modelBuilder.Entity<RestaurantArea>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .Property(e => e.Balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .Property(e => e.RoomFees)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .HasMany(e => e.OrderDesks)
                .WithRequired(e => e.RestaurantAreaDesk)
                .HasForeignKey(e => e.DeskID);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .HasMany(e => e.RestaurantAreaDeskInRestaurantAreaDeskCosts)
                .WithRequired(e => e.RestaurantAreaDesk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .HasMany(e => e.RestaurantAreaDeskFacilities)
                .WithMany(e => e.RestaurantAreaDesks)
                .Map(m => m.ToTable("RestaurantAreaDeskInRestaurantAreaDeskFacility").MapLeftKey("DeskGuID").MapRightKey("RestaurantAreaDeskFacilityID"));

            modelBuilder.Entity<RestaurantAreaDeskClassification>()
                .Property(e => e.RestaurantAreaDeskClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantAreaDeskCost>()
                .Property(e => e.RestaurantAreaDeskCostName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantAreaDeskFacility>()
                .Property(e => e.RestaurantAreaDeskFacilityName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantAreaDeskInRestaurantAreaDeskCost>()
                .Property(e => e.Balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantBanquet>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBanquet>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.ImportantMobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.DiningRoomArea)
                .HasPrecision(5, 0);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.AverageSpendBegin)
                .HasPrecision(5, 0);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.AverageSpendEnd)
                .HasPrecision(5, 0);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.BusinessLicenseImg)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.CorporateIDCardImg)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.HealthPermitsImg)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.LegalPerson)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.LicensePhone)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.LicenseNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.ApplicationFrom)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.Chain)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.AssessmentScale)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantBasicInfo>()
                .Property(e => e.DefaultMealTimeJson)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.ImportantMobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.DiningRoomArea)
                .HasPrecision(5, 0);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.AverageSpendBegin)
                .HasPrecision(5, 0);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.AverageSpendEnd)
                .HasPrecision(5, 0);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.BusinessLicenseImg)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.CorporateIDCardImg)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.HealthPermitsImg)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.LegalPerson)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.LicensePhone)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.LicenseNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.ApplicationFrom)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.Chain)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.AssessmentScale)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantBasicInfoI>()
                .Property(e => e.DefaultMealTimeJson)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantClassification>()
                .Property(e => e.RestaurantClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantFinanceClassification>()
                .Property(e => e.RestaurantFinanceClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantInvoice>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(10, 0);

            modelBuilder.Entity<RestaurantInvoice>()
                .Property(e => e.TaxpayerNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantInvoice>()
                .Property(e => e.OpenBank)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantInvoice>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantInvoice>()
                .Property(e => e.InvoiceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantInvoice>()
                .Property(e => e.InvoicePhone)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantLicense>()
                .Property(e => e.LicenseName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantLicense>()
                .Property(e => e.LicenseAddr)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantLicense>()
                .Property(e => e.LegalPerson)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantLicense>()
                .Property(e => e.BusinessScope)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantLicense>()
                .Property(e => e.LicenseNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantLicense>()
                .Property(e => e.LicensePhone)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantMealsTime>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.RestaurantMealsTime)
                .HasForeignKey(e => e.RestaurantMealsTimeGuid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantMealsTimeClassification>()
                .Property(e => e.RestaurantMealsTimeClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantMealsTimeClassification>()
                .HasMany(e => e.RestaurantMealsTimes)
                .WithRequired(e => e.RestaurantMealsTimeClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantMealsTimeClassification>()
                .HasMany(e => e.RestaurantMealsTimeClassificationInTimes)
                .WithRequired(e => e.RestaurantMealsTimeClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantProduct>()
                .Property(e => e.BuyPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<RestaurantProduct>()
                .Property(e => e.SiteProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<RestaurantProduct>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<RestaurantProduct>()
                .Property(e => e.ROP)
                .HasPrecision(10, 4);

            modelBuilder.Entity<RestaurantProduct>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantRFM>()
                .Property(e => e.RFMName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantRFM>()
                .HasMany(e => e.CustomerAliasClassificationInRestaurantRFMs)
                .WithRequired(e => e.RestaurantRFM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFM>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.RestaurantRFM)
                .HasForeignKey(e => e.RFM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .Property(e => e.RestaurantRFMClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.RestaurantRFMClassification)
                .HasForeignKey(e => e.RFMClassifiyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.RestaurantRFMClassification)
                .HasForeignKey(e => e.RFMClassifiyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .HasMany(e => e.RestaurantCustomerAutomaticClassifications)
                .WithRequired(e => e.RestaurantRFMClassification)
                .HasForeignKey(e => e.RFMClassifiyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .HasMany(e => e.RestaurantRFMs)
                .WithRequired(e => e.RestaurantRFMClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMverage>()
                .Property(e => e.Fvalue)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantRFMverage>()
                .Property(e => e.Mvalue)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantRFMverage>()
                .Property(e => e.Rvalue)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantRFMverage>()
                .Property(e => e.Avlaue)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RestaurantUser>()
                .HasMany(e => e.RestaurantUser1)
                .WithOptional(e => e.RestaurantUser2)
                .HasForeignKey(e => e.UserParentGuid);

            modelBuilder.Entity<RestaurantWorthClassification>()
                .Property(e => e.RestaurantWorthClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<SmsSendStateRecord>()
                .Property(e => e.SendPhone)
                .IsUnicode(false);

            modelBuilder.Entity<SmsSendStateRecord>()
                .Property(e => e.Timestap)
                .IsFixedLength();

            modelBuilder.Entity<t_Charge_Info>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<t_Charge_Info>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.SmsMarketingMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.SmsMarketingProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.SmsNoticeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.SmsNoticeProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.OrderMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.OrderProfit)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.ProductMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.ProductProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.RechargeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.RechargeProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.PayMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.Withdrawals_Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.OtherPayMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.OtherInComeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.Archive_Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Finance_Detail>()
                .Property(e => e.Account_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_InCome_Detail>()
                .Property(e => e.Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_InCome_Detail>()
                .Property(e => e.BeforeTheFinancial)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Pay_Detail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Pay_Detail>()
                .Property(e => e.Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Pay_Detail>()
                .Property(e => e.BeforeTheFinancial)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_SendSMS>()
                .Property(e => e.SmsPrice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<T_SendSMS>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<T_SendSMS>()
                .Property(e => e.ProfitRate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<T_SendSMS>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(16, 4);

            modelBuilder.Entity<T_SendSMS>()
                .Property(e => e.SiteProfitRate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<T_SendSMS>()
                .Property(e => e.SiteProfitMoney)
                .HasPrecision(16, 4);

            modelBuilder.Entity<T_Stat_ActiveMemberValue>()
                .Property(e => e.OrderOfFrequency)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_ActiveMemberValue>()
                .Property(e => e.RecentDiningTime)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_ActiveMemberValue>()
                .Property(e => e.AverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_ActiveMemberValue>()
                .Property(e => e.Expendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Head>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_CustomerOrder_Detail>()
                .Property(e => e.OredeMoney)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.SmsMarketingMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.SmsMarketingProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.SmsNoticeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.SmsNoticeProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.OrderMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.OrderProfit)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.ProductMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.ProductProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.RechargeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.RechargeProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.PayMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.Withdrawals_Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.OtherPayMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.OtherInComeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.Archive_Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Detail>()
                .Property(e => e.Account_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.SmsMarketingMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.SmsMarketingProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.SmsNoticeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.SmsNoticeProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.OrderMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.OrderProfit)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.ProductMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.ProductProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.RechargeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.RechargeProfitMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.PayMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.Withdrawals_Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.OtherPayMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.OtherInComeMoney)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.Archive_Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Head>()
                .Property(e => e.Account_Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_Stat_Marketing_Detail>()
                .Property(e => e.OrderMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<T_Stat_Marketing_Head>()
                .Property(e => e.OrderMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<T_Stat_Order_Detail>()
                .Property(e => e.SpendAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Order_Detail>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Order_Detail>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Order_Head>()
                .Property(e => e.SpendAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Order_Head>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Order_Head>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Order_Head>()
                .Property(e => e.SpendAbility)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.RestaurantName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.TheBus)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.ImportantContacts)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.ImportantMobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.ContractMoney)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.ContractRemark)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.ContractNum)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.Contacts)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Restaurant_Total>()
                .Property(e => e.ContactsPhone)
                .IsUnicode(false);

            modelBuilder.Entity<T_Withdraw_Detail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Withdraw_Detail>()
                .Property(e => e.Money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.WorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.AdminManageUser)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CustomerTagClickLogs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RestaurantMealsTimes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UserInAgent)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserLoginLogs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserPhones)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserQuit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserQuit>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.AppId)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.CallId)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.RequestId)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.Callee)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.DstVirtualNum)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.UserFlag)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.CallStatus)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.ErrorCode)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.TimeStamp)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.BindId)
                .IsUnicode(false);

            modelBuilder.Entity<ConversationStatu>()
                .Property(e => e.CalleeDisplayNum)
                .IsUnicode(false);

            modelBuilder.Entity<DstVirtualNumInfo>()
                .Property(e => e.DstVirtualNum)
                .IsUnicode(false);

            modelBuilder.Entity<DstVirtualNumInfo>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.AppId)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.CallId)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.RequestId)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.Callee)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.DstVirtualNum)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.recordUrl)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.BindId)
                .IsUnicode(false);

            modelBuilder.Entity<SoundRecording>()
                .Property(e => e.CalleeDisplayNum)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.AppId)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.CallId)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.RequestId)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.Caller)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.Callee)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.DstVirtualNum)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.CallerDuration)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.CalleeDuration)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.BindId)
                .IsUnicode(false);

            modelBuilder.Entity<TelOrder>()
                .Property(e => e.CalleeDisplayNum)
                .IsUnicode(false);

            modelBuilder.Entity<WXDZUserShareLog>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialClassification>()
                .HasMany(e => e.Materials)
                .WithRequired(e => e.MaterialClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhoneValidCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<QrCode>()
                .HasMany(e => e.QrCodeLogs)
                .WithRequired(e => e.QrCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QrCode>()
                .HasMany(e => e.QrCodeStats)
                .WithRequired(e => e.QrCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WXMarkingSend>()
                .HasMany(e => e.WXBirthdayMarkingSends)
                .WithRequired(e => e.WXMarkingSend)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LunisolarData>()
                .Property(e => e.data)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LunisolarData>()
                .Property(e => e.Data1)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingToCustomer_bak>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingToCustomer_bak>()
                .Property(e => e.LoadExpendamount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MarketingToCustomer_bak>()
                .Property(e => e.LoadAverageSpend)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MarketingToCustomer_bak>()
                .Property(e => e.LoadOrderOfFrequency)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MarketingToCustomer_bak>()
                .Property(e => e.LoadRecentDiningTime)
                .HasPrecision(10, 2);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.Requirement)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.Deposit)
            //    .HasPrecision(10, 2);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.CustomerPhoneNumber)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.CustomerName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.CustomerUnit)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.CustomerClassificationName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.UserSeviceName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.UserOwnerName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.AggregateAmount)
            //    .HasPrecision(10, 2);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.RestaurantMealsTimeName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Order_bak>()
            //    .Property(e => e.ApplyUserName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.Amount)
            //    .HasPrecision(10, 2);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.AreaName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.DeskName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.AgientProfitMoney)
            //    .HasPrecision(10, 4);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.ProfitRate)
            //    .HasPrecision(10, 4);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.ProfitPrice)
            //    .HasPrecision(10, 4);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.RestaurantMealsTimeName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OrderDesk_bak>()
            //    .Property(e => e.ExchangeTableUserName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.MemberTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.OrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.SelfOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.OtherOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.DingCanTaiOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.OtherReceiveOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.SpendAvg)
            //    .HasPrecision(10, 2);

            //modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
            //    .Property(e => e.DeskSpendAvg)
            //    .HasPrecision(10, 2);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.MemberTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.OrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.SelfOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.OtherOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.DingCanTaiOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.OtherReceiveOrderTotalMoney)
            //    .HasPrecision(20, 4);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.SpendAvg)
            //    .HasPrecision(10, 2);

            //modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
            //    .Property(e => e.DeskSpendAvg)
            //    .HasPrecision(10, 2);
        }
    }
}
