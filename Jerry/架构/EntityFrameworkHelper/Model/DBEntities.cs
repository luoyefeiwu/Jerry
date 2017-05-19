namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<ModuleOperation> ModuleOperation { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserModule> UserModule { get; set; }
        public virtual DbSet<ChainMarketing> ChainMarketing { get; set; }
        public virtual DbSet<ChainMarketingSend> ChainMarketingSend { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AdminManageUser> AdminManageUser { get; set; }
        public virtual DbSet<AdminUserModule> AdminUserModule { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<AgentChainCheckMsg> AgentChainCheckMsg { get; set; }
        public virtual DbSet<AgentCommissionRatio> AgentCommissionRatio { get; set; }
        public virtual DbSet<AgentInCity> AgentInCity { get; set; }
        public virtual DbSet<AgentInCityInProduct> AgentInCityInProduct { get; set; }
        public virtual DbSet<AgentInRestaurant> AgentInRestaurant { get; set; }
        public virtual DbSet<AgentInRestaurantRejectedRecord> AgentInRestaurantRejectedRecord { get; set; }
        public virtual DbSet<AgentReasonForRejection> AgentReasonForRejection { get; set; }
        public virtual DbSet<AnalysisBusinessTemporaryTask> AnalysisBusinessTemporaryTask { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<AuthTokenControlCenter> AuthTokenControlCenter { get; set; }
        public virtual DbSet<BaiDuMapping> BaiDuMapping { get; set; }
        public virtual DbSet<BaseSiteSetting> BaseSiteSetting { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CityBusinessDistrict> CityBusinessDistrict { get; set; }
        public virtual DbSet<CityLandMark> CityLandMark { get; set; }
        public virtual DbSet<CityOrderBrokerage> CityOrderBrokerage { get; set; }
        public virtual DbSet<CommErrorLog> CommErrorLog { get; set; }
        public virtual DbSet<Cuisine> Cuisine { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAliasClassification> CustomerAliasClassification { get; set; }
        public virtual DbSet<CustomerAliasClassificationInRestaurantRFM> CustomerAliasClassificationInRestaurantRFM { get; set; }
        public virtual DbSet<CustomerAnniversary> CustomerAnniversary { get; set; }
        public virtual DbSet<CustomerAnniversaryClassification> CustomerAnniversaryClassification { get; set; }
        public virtual DbSet<CustomerAppellation> CustomerAppellation { get; set; }
        public virtual DbSet<CustomerAssginStat> CustomerAssginStat { get; set; }
        public virtual DbSet<CustomerAssginStatLog> CustomerAssginStatLog { get; set; }
        public virtual DbSet<CustomerBadRecord> CustomerBadRecord { get; set; }
        public virtual DbSet<CustomerDisease> CustomerDisease { get; set; }
        public virtual DbSet<CustomerInfoChange> CustomerInfoChange { get; set; }
        public virtual DbSet<CustomerMemo> CustomerMemo { get; set; }
        public virtual DbSet<CustomerMerge> CustomerMerge { get; set; }
        public virtual DbSet<CustomerMergeLog> CustomerMergeLog { get; set; }
        public virtual DbSet<CustomerMultipleCount> CustomerMultipleCount { get; set; }
        public virtual DbSet<CustomerNote> CustomerNote { get; set; }
        public virtual DbSet<CustomerSurvey> CustomerSurvey { get; set; }
        public virtual DbSet<CustomerSurveyClassification> CustomerSurveyClassification { get; set; }
        public virtual DbSet<CustomerTag> CustomerTag { get; set; }
        public virtual DbSet<CustomerTagClickLog> CustomerTagClickLog { get; set; }
        public virtual DbSet<Deskcommission> Deskcommission { get; set; }
        public virtual DbSet<DicData> DicData { get; set; }
        public virtual DbSet<Disease> Disease { get; set; }
        public virtual DbSet<ExtChannel> ExtChannel { get; set; }
        public virtual DbSet<ExtChannelCity> ExtChannelCity { get; set; }
        public virtual DbSet<ExtChannelDayStat> ExtChannelDayStat { get; set; }
        public virtual DbSet<ExtChannelMonthStat> ExtChannelMonthStat { get; set; }
        public virtual DbSet<ExtChannelPhone> ExtChannelPhone { get; set; }
        public virtual DbSet<ImportDataTemp_100> ImportDataTemp_100 { get; set; }
        public virtual DbSet<ManualTopUpLog> ManualTopUpLog { get; set; }
        public virtual DbSet<Marketing> Marketing { get; set; }
        public virtual DbSet<MarketingClassification> MarketingClassification { get; set; }
        public virtual DbSet<MarketingCount> MarketingCount { get; set; }
        public virtual DbSet<MarketingOrdination> MarketingOrdination { get; set; }
        public virtual DbSet<MarketingToCustomer> MarketingToCustomer { get; set; }
        public virtual DbSet<MarketingToCustomerToOrder> MarketingToCustomerToOrder { get; set; }
        public virtual DbSet<MarketingToRestaurant> MarketingToRestaurant { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDesk> OrderDesk { get; set; }
        public virtual DbSet<OrderDeskUpdateAmount> OrderDeskUpdateAmount { get; set; }
        public virtual DbSet<OrderInLabels> OrderInLabels { get; set; }
        public virtual DbSet<OrderInMarketing> OrderInMarketing { get; set; }
        public virtual DbSet<OrderOtherPayRecord> OrderOtherPayRecord { get; set; }
        public virtual DbSet<OrderPersonalized> OrderPersonalized { get; set; }
        public virtual DbSet<OrderPersonalizedPic> OrderPersonalizedPic { get; set; }
        public virtual DbSet<OrderRemarkLabel> OrderRemarkLabel { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<PhoneQuit> PhoneQuit { get; set; }
        public virtual DbSet<PhoneReserve> PhoneReserve { get; set; }
        public virtual DbSet<PhoneReserveArchive> PhoneReserveArchive { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCommissionRatio> ProductCommissionRatio { get; set; }
        public virtual DbSet<ResCuisine> ResCuisine { get; set; }
        public virtual DbSet<ReserveOrder> ReserveOrder { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<RestaurantAdditionalRecording> RestaurantAdditionalRecording { get; set; }
        public virtual DbSet<RestaurantArea> RestaurantArea { get; set; }
        public virtual DbSet<RestaurantAreaDesk> RestaurantAreaDesk { get; set; }
        public virtual DbSet<RestaurantAreaDeskChildren> RestaurantAreaDeskChildren { get; set; }
        public virtual DbSet<RestaurantAreaDeskClassification> RestaurantAreaDeskClassification { get; set; }
        public virtual DbSet<RestaurantAreaDeskCost> RestaurantAreaDeskCost { get; set; }
        public virtual DbSet<RestaurantAreaDeskFacility> RestaurantAreaDeskFacility { get; set; }
        public virtual DbSet<RestaurantAreaDeskInRestaurantAreaDeskCost> RestaurantAreaDeskInRestaurantAreaDeskCost { get; set; }
        public virtual DbSet<RestaurantAreaDeskPic> RestaurantAreaDeskPic { get; set; }
        public virtual DbSet<RestaurantAreaDeskRelation> RestaurantAreaDeskRelation { get; set; }
        public virtual DbSet<RestaurantAreaDeskRelationDetail> RestaurantAreaDeskRelationDetail { get; set; }
        public virtual DbSet<RestaurantBanquet> RestaurantBanquet { get; set; }
        public virtual DbSet<RestaurantBasicInfo> RestaurantBasicInfo { get; set; }
        public virtual DbSet<RestaurantClassification> RestaurantClassification { get; set; }
        public virtual DbSet<RestaurantCustomerAutomaticClassification> RestaurantCustomerAutomaticClassification { get; set; }
        public virtual DbSet<RestaurantCXJDeskInfo> RestaurantCXJDeskInfo { get; set; }
        public virtual DbSet<RestaurantDiscountRight> RestaurantDiscountRight { get; set; }
        public virtual DbSet<RestaurantDiscounts> RestaurantDiscounts { get; set; }
        public virtual DbSet<RestaurantFinanceClassification> RestaurantFinanceClassification { get; set; }
        public virtual DbSet<RestaurantInvoice> RestaurantInvoice { get; set; }
        public virtual DbSet<RestaurantLicense> RestaurantLicense { get; set; }
        public virtual DbSet<RestaurantMealsTime> RestaurantMealsTime { get; set; }
        public virtual DbSet<RestaurantMealsTimeClassification> RestaurantMealsTimeClassification { get; set; }
        public virtual DbSet<RestaurantMealsTimeClassificationInTime> RestaurantMealsTimeClassificationInTime { get; set; }
        public virtual DbSet<RestaurantOperaSettings> RestaurantOperaSettings { get; set; }
        public virtual DbSet<RestaurantOrderDeskCount> RestaurantOrderDeskCount { get; set; }
        public virtual DbSet<RestaurantPhone> RestaurantPhone { get; set; }
        public virtual DbSet<RestaurantProduct> RestaurantProduct { get; set; }
        public virtual DbSet<RestaurantRFM> RestaurantRFM { get; set; }
        public virtual DbSet<RestaurantRFMClassification> RestaurantRFMClassification { get; set; }
        public virtual DbSet<RestaurantRFMverage> RestaurantRFMverage { get; set; }
        public virtual DbSet<RestaurantSMSRoute> RestaurantSMSRoute { get; set; }
        public virtual DbSet<RestaurantSmsTemplate> RestaurantSmsTemplate { get; set; }
        public virtual DbSet<RestaurantTotalDetail> RestaurantTotalDetail { get; set; }
        public virtual DbSet<RestaurantUser> RestaurantUser { get; set; }
        public virtual DbSet<RestaurantUserAreaRights> RestaurantUserAreaRights { get; set; }
        public virtual DbSet<RestaurantUserAreaSaleRights> RestaurantUserAreaSaleRights { get; set; }
        public virtual DbSet<RestaurantUserComeTelRights> RestaurantUserComeTelRights { get; set; }
        public virtual DbSet<RestaurantWorthClassification> RestaurantWorthClassification { get; set; }
        public virtual DbSet<SmsPrice> SmsPrice { get; set; }
        public virtual DbSet<SmsSendStateRecord> SmsSendStateRecord { get; set; }
        public virtual DbSet<SmsTemplateParameter> SmsTemplateParameter { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
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
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserInAgent> UserInAgent { get; set; }
        public virtual DbSet<UserInChain> UserInChain { get; set; }
        public virtual DbSet<UserInCustomerClassification> UserInCustomerClassification { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLog { get; set; }
        public virtual DbSet<UserOperateLog> UserOperateLog { get; set; }
        public virtual DbSet<UserPhone> UserPhone { get; set; }
        public virtual DbSet<UserQuit> UserQuit { get; set; }
        public virtual DbSet<UserSetting> UserSetting { get; set; }
        public virtual DbSet<DZFeedback> DZFeedback { get; set; }
        public virtual DbSet<DZUserInfo> DZUserInfo { get; set; }
        public virtual DbSet<WXDZUser> WXDZUser { get; set; }
        public virtual DbSet<WXDZUserShareLog> WXDZUserShareLog { get; set; }
        public virtual DbSet<RestaurantOpen> RestaurantOpen { get; set; }
        public virtual DbSet<UserReportSetting> UserReportSetting { get; set; }
        public virtual DbSet<CreditChangeLog> CreditChangeLog { get; set; }
        public virtual DbSet<CustomerCredit> CustomerCredit { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialClassification> MaterialClassification { get; set; }
        public virtual DbSet<MessageNotice> MessageNotice { get; set; }
        public virtual DbSet<PhoneValidCode> PhoneValidCode { get; set; }
        public virtual DbSet<QrCode> QrCode { get; set; }
        public virtual DbSet<QrCodeLog> QrCodeLog { get; set; }
        public virtual DbSet<QrCodeStat> QrCodeStat { get; set; }
        public virtual DbSet<ResReply> ResReply { get; set; }
        public virtual DbSet<WXBirthdayMarkingSend> WXBirthdayMarkingSend { get; set; }
        public virtual DbSet<WXCustomer> WXCustomer { get; set; }
        public virtual DbSet<WXCustomerRelation> WXCustomerRelation { get; set; }
        public virtual DbSet<WXMarkingSend> WXMarkingSend { get; set; }
        public virtual DbSet<WXPublicAccount> WXPublicAccount { get; set; }
        public virtual DbSet<WXRes> WXRes { get; set; }
        public virtual DbSet<WXUser> WXUser { get; set; }
        public virtual DbSet<WXUserSendRecord> WXUserSendRecord { get; set; }
        public virtual DbSet<LunisolarDatas> LunisolarDatas { get; set; }
        public virtual DbSet<ImportDataTemp> ImportDataTemp { get; set; }
        public virtual DbSet<ImportDataTemp_0308bak> ImportDataTemp_0308bak { get; set; }
        public virtual DbSet<ImportDataTemp_0309_1bak> ImportDataTemp_0309_1bak { get; set; }
        public virtual DbSet<ImportDataTemp0313> ImportDataTemp0313 { get; set; }
        public virtual DbSet<ImportDataTemp03131> ImportDataTemp03131 { get; set; }
        public virtual DbSet<MarketingToCustomer_bak> MarketingToCustomer_bak { get; set; }
        public virtual DbSet<Order_0307bak> Order_0307bak { get; set; }
        public virtual DbSet<Order_0308bak> Order_0308bak { get; set; }
        public virtual DbSet<Order_bak> Order_bak { get; set; }
        public virtual DbSet<Order0309bak> Order0309bak { get; set; }
        public virtual DbSet<Order0313> Order0313 { get; set; }
        public virtual DbSet<Order03131> Order03131 { get; set; }
        public virtual DbSet<OrderDesk_0307bak> OrderDesk_0307bak { get; set; }
        public virtual DbSet<OrderDesk_0308bak> OrderDesk_0308bak { get; set; }
        public virtual DbSet<OrderDesk_bak> OrderDesk_bak { get; set; }
        public virtual DbSet<OrderDesk0309bak> OrderDesk0309bak { get; set; }
        public virtual DbSet<OrderDesk0313> OrderDesk0313 { get; set; }
        public virtual DbSet<OrderDesk03131> OrderDesk03131 { get; set; }
        public virtual DbSet<PhoneReserve_bak> PhoneReserve_bak { get; set; }
        public virtual DbSet<ReserveOrder_0307bak> ReserveOrder_0307bak { get; set; }
        public virtual DbSet<ReserveOrder_0308bak> ReserveOrder_0308bak { get; set; }
        public virtual DbSet<RestaurantOrderDeskCount_bak> RestaurantOrderDeskCount_bak { get; set; }
        public virtual DbSet<T_Stat_Channel_Detail_0307bak> T_Stat_Channel_Detail_0307bak { get; set; }
        public virtual DbSet<T_Stat_Channel_Detail_0308bak> T_Stat_Channel_Detail_0308bak { get; set; }
        public virtual DbSet<T_Stat_Channel_Detail_20161122bak> T_Stat_Channel_Detail_20161122bak { get; set; }
        public virtual DbSet<T_Stat_Channel_Detail_bak> T_Stat_Channel_Detail_bak { get; set; }
        public virtual DbSet<T_Stat_Channel_Head_0307bak> T_Stat_Channel_Head_0307bak { get; set; }
        public virtual DbSet<T_Stat_Channel_Head_0308bak> T_Stat_Channel_Head_0308bak { get; set; }
        public virtual DbSet<UserOperateLog_bak> UserOperateLog_bak { get; set; }
        public virtual DbSet<DZUserOrder> DZUserOrder { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Module>()
                .HasMany(e => e.ModuleOperation)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.UserModule)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Page)
                .WithMany(e => e.Module)
                .Map(m => m.ToTable("ModulePage", "Authorization").MapLeftKey("ModuleId").MapRightKey("PageId"));

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Product)
                .WithMany(e => e.Module)
                .Map(m => m.ToTable("ProductModule", "Authorization").MapLeftKey("ModuleId").MapRightKey("ProductID"));

            modelBuilder.Entity<Module>()
                .HasMany(e => e.UserGroup)
                .WithMany(e => e.Module)
                .Map(m => m.ToTable("UserGroupModule", "Authorization").MapLeftKey("ModuleId").MapRightKey("GroupType"));

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.ModuleOperation)
                .WithRequired(e => e.Operation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Page>()
                .HasMany(e => e.ModuleOperation)
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
                .HasMany(e => e.AgentCommissionRatio)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentInCity)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentInRestaurant)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentInRestaurantRejectedRecord)
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
                .HasMany(e => e.Module)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.User)
                .WithMany(e => e.Application)
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
                .HasMany(e => e.AgentCommissionRatio)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.AgentInCity)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.CityBusinessDistrict)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.CityLandMark)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.CityOrderBrokerage)
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
                .HasMany(e => e.Restaurant)
                .WithMany(e => e.CityBusinessDistrict)
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
                .HasMany(e => e.ResCuisine)
                .WithRequired(e => e.Cuisine)
                .HasForeignKey(e => e.CuisineLevel2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuisine>()
                .HasMany(e => e.ResCuisine1)
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
                .HasMany(e => e.CustomerBadRecord)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerID);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerDisease)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.CustomerMultipleCount)
                .WithRequired(e => e.Customer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerSurvey)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerTag)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.MarketingToCustomer)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Phone)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ReserveOrder)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerAliasClassification>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAliasClassification>()
                .HasMany(e => e.Customer)
                .WithRequired(e => e.CustomerAliasClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerAliasClassification>()
                .HasMany(e => e.CustomerAliasClassificationInRestaurantRFM)
                .WithRequired(e => e.CustomerAliasClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerBadRecord>()
                .Property(e => e.BadRecord)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerMultipleCount>()
                .Property(e => e.Amont)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CustomerSurveyClassification>()
                .Property(e => e.CustomerSurveyClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerSurveyClassification>()
                .HasMany(e => e.CustomerSurvey)
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
                .HasMany(e => e.CustomerTagClickLog)
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
                .HasMany(e => e.CustomerDisease)
                .WithRequired(e => e.Disease)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExtChannel>()
                .HasMany(e => e.ExtChannelPhone)
                .WithRequired(e => e.ExtChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExtChannel>()
                .HasMany(e => e.ExtChannelCity)
                .WithRequired(e => e.ExtChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ImportDataTemp_100>()
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
                .HasMany(e => e.MarketingToCustomer)
                .WithRequired(e => e.Marketing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marketing>()
                .HasMany(e => e.OrderInMarketing)
                .WithRequired(e => e.Marketing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marketing>()
                .HasMany(e => e.SmsSendStateRecord)
                .WithRequired(e => e.Marketing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarketingClassification>()
                .Property(e => e.MarketingClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<MarketingClassification>()
                .HasMany(e => e.MarketingCount)
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
                .HasMany(e => e.OrderDesk)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderInMarketing)
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
                .HasMany(e => e.ProductCommissionRatio)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.RestaurantProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.t_Charge_Info)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ChargeItem)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.AgentInRestaurantRejectedRecord)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Customer)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.CustomerAliasClassification)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.CustomerAliasClassificationInRestaurantRFM)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.CustomerBadRecord)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.OrderRemarkLabel)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Phone)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.ResCuisine)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.ReserveOrder)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.MaterialClassification)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Material)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.QrCode)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.QrCodeLog)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.QrCodeStat)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantUser)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantPhone)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasOptional(e => e.RestaurantOpen)
                .WithRequired(e => e.Restaurant);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantArea)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantAreaDesk)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasOptional(e => e.RestaurantBasicInfo)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantCustomerAutomaticClassification)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasOptional(e => e.RestaurantLicense)
                .WithRequired(e => e.Restaurant);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantMealsTime)
                .WithOptional(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantProduct)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasOptional(e => e.RestaurantRFMverage)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.SmsSendStateRecord)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.UserLoginLog)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.UserQuit)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantClassification)
                .WithMany(e => e.Restaurant)
                .Map(m => m.ToTable("RestaurantInRestaurantClassification").MapLeftKey("RestaurantGuid").MapRightKey("RestaurantClassificationId"));

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.RestaurantMealsTimeClassification)
                .WithMany(e => e.Restaurant)
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
                .HasMany(e => e.OrderDesk)
                .WithRequired(e => e.RestaurantAreaDesk)
                .HasForeignKey(e => e.DeskID);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .HasMany(e => e.RestaurantAreaDeskInRestaurantAreaDeskCost)
                .WithRequired(e => e.RestaurantAreaDesk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantAreaDesk>()
                .HasMany(e => e.RestaurantAreaDeskFacility)
                .WithMany(e => e.RestaurantAreaDesk)
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
                .HasMany(e => e.Order)
                .WithRequired(e => e.RestaurantMealsTime)
                .HasForeignKey(e => e.RestaurantMealsTimeGuid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantMealsTimeClassification>()
                .Property(e => e.RestaurantMealsTimeClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<RestaurantMealsTimeClassification>()
                .HasMany(e => e.RestaurantMealsTime)
                .WithRequired(e => e.RestaurantMealsTimeClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantMealsTimeClassification>()
                .HasMany(e => e.RestaurantMealsTimeClassificationInTime)
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
                .HasMany(e => e.CustomerAliasClassificationInRestaurantRFM)
                .WithRequired(e => e.RestaurantRFM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFM>()
                .HasMany(e => e.Order)
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
                .HasMany(e => e.Customer)
                .WithRequired(e => e.RestaurantRFMClassification)
                .HasForeignKey(e => e.RFMClassifiyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.RestaurantRFMClassification)
                .HasForeignKey(e => e.RFMClassifiyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .HasMany(e => e.RestaurantCustomerAutomaticClassification)
                .WithRequired(e => e.RestaurantRFMClassification)
                .HasForeignKey(e => e.RFMClassifiyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantRFMClassification>()
                .HasMany(e => e.RestaurantRFM)
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
                .HasMany(e => e.CustomerTagClickLog)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RestaurantMealsTime)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UserInAgent)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserLoginLog)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserPhone)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserQuit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserQuit>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<WXDZUserShareLog>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialClassification>()
                .HasMany(e => e.Material)
                .WithRequired(e => e.MaterialClassification)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhoneValidCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<QrCode>()
                .HasMany(e => e.QrCodeLog)
                .WithRequired(e => e.QrCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QrCode>()
                .HasMany(e => e.QrCodeStat)
                .WithRequired(e => e.QrCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WXMarkingSend>()
                .HasMany(e => e.WXBirthdayMarkingSend)
                .WithRequired(e => e.WXMarkingSend)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LunisolarDatas>()
                .Property(e => e.data)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LunisolarDatas>()
                .Property(e => e.Data1)
                .IsUnicode(false);

            modelBuilder.Entity<ImportDataTemp>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ImportDataTemp_0308bak>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ImportDataTemp_0309_1bak>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ImportDataTemp0313>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ImportDataTemp03131>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

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

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.Requirement)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.Deposit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.UserOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.AggregateAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0307bak>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.Requirement)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.Deposit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.UserOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.AggregateAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_0308bak>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.Requirement)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.Deposit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.UserOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.AggregateAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<Order_bak>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.Requirement)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.Deposit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.UserOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.AggregateAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0309bak>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.Requirement)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.Deposit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.UserOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.AggregateAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<Order0313>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.Requirement)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.Deposit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.CustomerUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.CustomerClassificationName)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.UserSeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.UserOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.AggregateAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<Order03131>()
                .Property(e => e.ApplyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.ProfitRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0307bak>()
                .Property(e => e.ExchangeTableUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.ProfitRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_0308bak>()
                .Property(e => e.ExchangeTableUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.ProfitRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk_bak>()
                .Property(e => e.ExchangeTableUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.ProfitRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0309bak>()
                .Property(e => e.ExchangeTableUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.ProfitRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk0313>()
                .Property(e => e.ExchangeTableUserName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.DeskName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.AgientProfitMoney)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.ProfitRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.ProfitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.RestaurantMealsTimeName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDesk03131>()
                .Property(e => e.ExchangeTableUserName)
                .IsUnicode(false);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail_0307bak>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail_0308bak>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail_20161122bak>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Detail_bak>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Head_0307bak>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.MemberTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.OrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.SelfOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.OtherOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.DingCanTaiOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.OtherReceiveOrderTotalMoney)
                .HasPrecision(20, 4);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.DeskSpendAvg)
                .HasPrecision(10, 2);

            modelBuilder.Entity<T_Stat_Channel_Head_0308bak>()
                .Property(e => e.SpendAvg)
                .HasPrecision(10, 2);
        }
    }
}
