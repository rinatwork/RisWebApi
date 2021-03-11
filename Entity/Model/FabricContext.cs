using Microsoft.EntityFrameworkCore;


namespace Entity.Model
{
    public partial class FabricContext : DbContext
    {
        public FabricContext()
        {
        }

        public FabricContext(DbContextOptions<FabricContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccNumberLibrary> AccNumberLibraries { get; set; }
        public virtual DbSet<AccessFunction> AccessFunctions { get; set; }
        public virtual DbSet<AccessFunctionType> AccessFunctionTypes { get; set; }
        public virtual DbSet<Anotomical> Anotomicals { get; set; }
        public virtual DbSet<ArrangeIndex> ArrangeIndices { get; set; }
        public virtual DbSet<ArrangeIndexSolution> ArrangeIndexSolutions { get; set; }
        public virtual DbSet<ArrangeItem> ArrangeItems { get; set; }
        public virtual DbSet<ArrangeLogin> ArrangeLogins { get; set; }
        public virtual DbSet<ArrangeMutualExclusion> ArrangeMutualExclusions { get; set; }
        public virtual DbSet<ArrangeResult> ArrangeResults { get; set; }
        public virtual DbSet<ArrangeTime> ArrangeTimes { get; set; }
        public virtual DbSet<BackUpPatient> BackUpPatients { get; set; }
        public virtual DbSet<BackUpStudy> BackUpStudies { get; set; }
        public virtual DbSet<BackUpStudyFeeItemIndex> BackUpStudyFeeItemIndices { get; set; }
        public virtual DbSet<BackUpStudyItemIndex> BackUpStudyItemIndices { get; set; }
        public virtual DbSet<BackUpStudyQuestFile> BackUpStudyQuestFiles { get; set; }
        public virtual DbSet<BackUpStudySchInfo> BackUpStudySchInfos { get; set; }
        public virtual DbSet<CallingMonitor> CallingMonitors { get; set; }
        public virtual DbSet<CallingMonitorInfo> CallingMonitorInfos { get; set; }
        public virtual DbSet<CallingMonitorQueue> CallingMonitorQueues { get; set; }
        public virtual DbSet<CaseRecord> CaseRecords { get; set; }
        public virtual DbSet<CategoryDetail> CategoryDetails { get; set; }
        public virtual DbSet<CategoryType> CategoryTypes { get; set; }
        public virtual DbSet<CheckItemSum> CheckItemSums { get; set; }
        public virtual DbSet<ClinicianInfo> ClinicianInfos { get; set; }
        public virtual DbSet<Column> Columns { get; set; }
        public virtual DbSet<DangerKeyDic> DangerKeyDics { get; set; }
        public virtual DbSet<DangerKeyDicItemIndex> DangerKeyDicItemIndices { get; set; }
        public virtual DbSet<DangerLog> DangerLogs { get; set; }
        public virtual DbSet<DataStream> DataStreams { get; set; }
        public virtual DbSet<DatasourceTjlxke> DatasourceTjlxkes { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentClinicianIndex> DepartmentClinicianIndices { get; set; }
        public virtual DbSet<DepartmentRegionIndex> DepartmentRegionIndices { get; set; }
        public virtual DbSet<DeptClass> DeptClasses { get; set; }
        public virtual DbSet<DeviceInfo> DeviceInfos { get; set; }
        public virtual DbSet<DyestuffPatientView> DyestuffPatientViews { get; set; }
        public virtual DbSet<DyestuffReportParamsView> DyestuffReportParamsViews { get; set; }
        public virtual DbSet<DyestuffReportView> DyestuffReportViews { get; set; }
        public virtual DbSet<DyestuffReportViewNk> DyestuffReportViewNks { get; set; }
        public virtual DbSet<DynInfo> DynInfos { get; set; }
        public virtual DbSet<ExamRoom> ExamRooms { get; set; }
        public virtual DbSet<ExamRoomModeIndex> ExamRoomModeIndices { get; set; }
        public virtual DbSet<ExamRoomQueue> ExamRoomQueues { get; set; }
        public virtual DbSet<ExpertTemplate> ExpertTemplates { get; set; }
        public virtual DbSet<FeeInfo> FeeInfos { get; set; }
        public virtual DbSet<FeeModeIndex> FeeModeIndices { get; set; }
        public virtual DbSet<FeeType> FeeTypes { get; set; }
        public virtual DbSet<FileUpLoadRecord> FileUpLoadRecords { get; set; }
        public virtual DbSet<FilmInfo> FilmInfos { get; set; }
        public virtual DbSet<FinalReport> FinalReports { get; set; }
        public virtual DbSet<FinalSection> FinalSections { get; set; }
        public virtual DbSet<FollowupKey> FollowupKeys { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupAccess> GroupAccesses { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<HospitalInfo> HospitalInfos { get; set; }
        public virtual DbSet<Icdcode> Icdcodes { get; set; }
        public virtual DbSet<InterMessage> InterMessages { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemDiagFilter> ItemDiagFilters { get; set; }
        public virtual DbSet<ItemDicomInfo> ItemDicomInfos { get; set; }
        public virtual DbSet<ItemFeeIndex> ItemFeeIndices { get; set; }
        public virtual DbSet<ItemModeIndex> ItemModeIndices { get; set; }
        public virtual DbSet<ItemSplitDetail> ItemSplitDetails { get; set; }
        public virtual DbSet<ItemTemplate> ItemTemplates { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<ItemTypeExpert> ItemTypeExperts { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Mod> Mods { get; set; }
        public virtual DbSet<Mode> Modes { get; set; }
        public virtual DbSet<ModeType> ModeTypes { get; set; }
        public virtual DbSet<ModeTypeExpert> ModeTypeExperts { get; set; }
        public virtual DbSet<NumberSeed> NumberSeeds { get; set; }
        public virtual DbSet<Pathological> Pathologicals { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientExtra> PatientExtras { get; set; }
        public virtual DbSet<PatientVip> PatientVips { get; set; }
        public virtual DbSet<PostSum> PostSums { get; set; }
        public virtual DbSet<QualityControlDetail> QualityControlDetails { get; set; }
        public virtual DbSet<QualityControlInfo> QualityControlInfos { get; set; }
        public virtual DbSet<QualityControlLog> QualityControlLogs { get; set; }
        public virtual DbSet<QualityControlMonth> QualityControlMonths { get; set; }
        public virtual DbSet<Queue> Queues { get; set; }
        public virtual DbSet<QueueContainerDb> QueueContainerDbs { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RelationSum> RelationSums { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportGradeInfo> ReportGradeInfos { get; set; }
        public virtual DbSet<RightManage> RightManages { get; set; }
        public virtual DbSet<RolePost> RolePosts { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SectionExtra> SectionExtras { get; set; }
        public virtual DbSet<ShiftDate> ShiftDates { get; set; }
        public virtual DbSet<ShiftManage> ShiftManages { get; set; }
        public virtual DbSet<ShiftManageN> ShiftManageNs { get; set; }
        public virtual DbSet<ShiftManageView> ShiftManageViews { get; set; }
        public virtual DbSet<Shiftdeptstaff> Shiftdeptstaffs { get; set; }
        public virtual DbSet<Shiftdeptstaff1> Shiftdeptstaffs1 { get; set; }
        public virtual DbSet<SmartprintGetimagedatum> SmartprintGetimagedata { get; set; }
        public virtual DbSet<StaffPost> StaffPosts { get; set; }
        public virtual DbSet<StationColumn> StationColumns { get; set; }
        public virtual DbSet<Study> Studies { get; set; }
        public virtual DbSet<StudyAcrindex> StudyAcrindices { get; set; }
        public virtual DbSet<StudyCategoryIndex> StudyCategoryIndices { get; set; }
        public virtual DbSet<StudyDiagnoseQuality> StudyDiagnoseQualities { get; set; }
        public virtual DbSet<StudyDiagnoseQualityLog> StudyDiagnoseQualityLogs { get; set; }
        public virtual DbSet<StudyExtra> StudyExtras { get; set; }
        public virtual DbSet<StudyFeeItemIndex> StudyFeeItemIndices { get; set; }
        public virtual DbSet<StudyImageInfo> StudyImageInfos { get; set; }
        public virtual DbSet<StudyItemIndex> StudyItemIndices { get; set; }
        public virtual DbSet<StudyKeyImage> StudyKeyImages { get; set; }
        public virtual DbSet<StudyLock> StudyLocks { get; set; }
        public virtual DbSet<StudyLog> StudyLogs { get; set; }
        public virtual DbSet<StudyPrintingLog> StudyPrintingLogs { get; set; }
        public virtual DbSet<StudyQuestFile> StudyQuestFiles { get; set; }
        public virtual DbSet<StudyQueue> StudyQueues { get; set; }
        public virtual DbSet<StudySchInfo> StudySchInfos { get; set; }
        public virtual DbSet<StudySchInfoHi> StudySchInfoHis { get; set; }
        public virtual DbSet<StudySchInfoHisItem> StudySchInfoHisItems { get; set; }
        public virtual DbSet<StudyStatusChange> StudyStatusChanges { get; set; }
        public virtual DbSet<StudyStatusLog> StudyStatusLogs { get; set; }
        public virtual DbSet<StudyTemp> StudyTemps { get; set; }
        public virtual DbSet<StudyTimeAxis> StudyTimeAxes { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        public virtual DbSet<StyleModeIndex> StyleModeIndices { get; set; }
        public virtual DbSet<StyleType> StyleTypes { get; set; }
        public virtual DbSet<SubAnotomical> SubAnotomicals { get; set; }
        public virtual DbSet<SubPathological> SubPathologicals { get; set; }
        public virtual DbSet<SurDcmWorklistView> SurDcmWorklistViews { get; set; }
        public virtual DbSet<SurDcmWorklistViewBak> SurDcmWorklistViewBaks { get; set; }
        public virtual DbSet<SurDcmWorklistViewtest> SurDcmWorklistViewtests { get; set; }
        public virtual DbSet<TechPlan> TechPlans { get; set; }
        public virtual DbSet<TechPlanDiscuss> TechPlanDiscusses { get; set; }
        public virtual DbSet<TechPlanFullView> TechPlanFullViews { get; set; }
        public virtual DbSet<TechPlanView> TechPlanViews { get; set; }
        public virtual DbSet<TechnicalPost> TechnicalPosts { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TestStudyFromHi> TestStudyFromHis { get; set; }
        public virtual DbSet<Tpdescription> Tpdescriptions { get; set; }
        public virtual DbSet<Tpdiscuss> Tpdiscusses { get; set; }
        public virtual DbSet<TpdiscussContent> TpdiscussContents { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCustomedSetting> UserCustomedSettings { get; set; }
        public virtual DbSet<UserDefaultSetting> UserDefaultSettings { get; set; }
        public virtual DbSet<UserInterMessage> UserInterMessages { get; set; }
        public virtual DbSet<UserKeyword> UserKeywords { get; set; }
        public virtual DbSet<UserModeIndex> UserModeIndices { get; set; }
        public virtual DbSet<UserQueryCondition> UserQueryConditions { get; set; }
        public virtual DbSet<UserToken> UserTokens { get; set; }
        public virtual DbSet<UsersAccess> UsersAccesses { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<ViewGetStudyInfo> ViewGetStudyInfos { get; set; }
        public virtual DbSet<VisitType> VisitTypes { get; set; }
        public virtual DbSet<VwStudyItemIndex> VwStudyItemIndices { get; set; }
        public virtual DbSet<Workstation> Workstations { get; set; }
        public virtual DbSet<YdPac> YdPacs { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=RINATWORK\\SQLEXPRESS;database=Fabric;integrated security=SSPI;uid=sa;pwd=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<AccNumberLibrary>(entity =>
            {
                entity.ToTable("AccNumberLibrary");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LockedBy).HasMaxLength(50);

                entity.Property(e => e.Seedid)
                    .HasMaxLength(50)
                    .HasColumnName("seedid");
            });

            modelBuilder.Entity<AccessFunction>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("AccessFunction");

                entity.HasIndex(e => e.AccessTypeGuid, "IX_AccessFunction_AccessTypeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.AccessTypeGuid)
                    .HasColumnName("AccessTypeGUID")
                    .HasComment("功能大类GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("代码");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasComment("备注");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");
            });

            modelBuilder.Entity<AccessFunctionType>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("AccessFunctionType");

                entity.HasIndex(e => e.OrderId, "IX_AccessFunctionType_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("代码");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("系统功能大类");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasComment("备注");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");
            });

            modelBuilder.Entity<Anotomical>(entity =>
            {
                entity.HasKey(e => e.Aid);

                entity.ToTable("Anotomical");

                entity.Property(e => e.Aid).ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_EN");
            });

            modelBuilder.Entity<ArrangeIndex>(entity =>
            {
                entity.ToTable("ArrangeIndex");

                entity.HasIndex(e => new { e.ArrangeItemGuid, e.ArrangeTimeGuid }, "IX_ArrangeIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.ArrangeItemGuid)
                    .HasColumnName("ArrangeItemGUID")
                    .HasComment("预约项目GUID");

                entity.Property(e => e.ArrangeTimeGuid)
                    .HasColumnName("ArrangeTimeGUID")
                    .HasComment("预约时间GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ClinicWeekdayNum).HasComment("临床工作日人数");

                entity.Property(e => e.ClinicWeekendNum).HasComment("临床休息日人数");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1753))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolutionGuid).HasColumnName("SolutionGUID");

                entity.Property(e => e.WeekdayNum).HasComment("工作日人数");

                entity.Property(e => e.WeekendNum).HasComment("休息日人数");

                entity.HasOne(d => d.ArrangeTimeGu)
                    .WithMany(p => p.ArrangeIndices)
                    .HasForeignKey(d => d.ArrangeTimeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArrangeIndex_ArrangeTime");
            });

            modelBuilder.Entity<ArrangeIndexSolution>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("ArrangeIndexSolution");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.AppliedTime).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.ModeGuid).HasColumnName("ModeGUID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArrangeItem>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ArrangeItem");

                entity.HasIndex(e => e.ModeGuid, "IX_ArrangeItem_ModeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("预约项目GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PY")
                    .HasComment("拼首");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.ArrangeItems)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArrangeItem_Mode");
            });

            modelBuilder.Entity<ArrangeLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArrangeLogin");

                entity.Property(e => e.ArrangePwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArrangeMutualExclusion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ArrangeMutualExclusion");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("comment");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasComment("min");
            });

            modelBuilder.Entity<ArrangeResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArrangeResult");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicaitonTime).HasColumnType("datetime");

                entity.Property(e => e.Blkh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BLKH");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("itemname");

                entity.Property(e => e.ModeGuid).HasColumnName("ModeGUID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlotTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArrangeTime>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ArrangeTime");

                entity.HasIndex(e => e.ModeGuid, "IX_ArrangeTime_ModeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("预约时间GUID");

                entity.Property(e => e.BeginTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("起点时间");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("终点时间");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式GUID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.TimeType).HasComment("时间类型标志");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.ArrangeTimes)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArrangeTime_Mode");
            });

            modelBuilder.Entity<BackUpPatient>(entity =>
            {
                entity.HasKey(e => e.BackUpGuid)
                    .IsClustered(false);

                entity.ToTable("BackUpPatient");

                entity.HasIndex(e => e.Name, "IX_BackUpPatient_Name")
                    .IsClustered();

                entity.Property(e => e.BackUpGuid)
                    .ValueGeneratedNever()
                    .HasColumnName("BackUpGUID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.Blh)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BLH");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("IDCard");

                entity.Property(e => e.ImgId)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.NamePinYin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("PY");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Vip).HasColumnName("VIP");

                entity.Property(e => e.Weight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ybkh)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("YBKH");

                entity.HasOne(d => d.BackUpGu)
                    .WithOne(p => p.BackUpPatient)
                    .HasForeignKey<BackUpPatient>(d => d.BackUpGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BackUpPatient_BackUpStudy");
            });

            modelBuilder.Entity<BackUpStudy>(entity =>
            {
                entity.HasKey(e => e.BackUpGuid)
                    .IsClustered(false);

                entity.ToTable("BackUpStudy");

                entity.HasIndex(e => e.AccNum, "IX_BackUpStudy_AccNum")
                    .IsClustered();

                entity.HasIndex(e => e.Guid, "IX_BackUpStudy_GUID");

                entity.Property(e => e.BackUpGuid)
                    .ValueGeneratedNever()
                    .HasColumnName("BackUpGUID");

                entity.Property(e => e.AccNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BedNo)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.CliniAge)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CliniAgeUnit)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CliniDeptGuid).HasColumnName("CliniDeptGUID");

                entity.Property(e => e.CliniDoctorGuid).HasColumnName("CliniDoctorGUID");

                entity.Property(e => e.CliniItem).HasMaxLength(150);

                entity.Property(e => e.CliniRequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CliniStudyDate).HasColumnType("datetime");

                entity.Property(e => e.EstimateCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.FeeTypeGuid).HasColumnName("FeeTypeGUID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModeGuid).HasColumnName("ModeGUID");

                entity.Property(e => e.ModeName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");

                entity.Property(e => e.ReferAccnum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RegOperatorGuid).HasColumnName("RegOperatorGUID");

                entity.Property(e => e.RegionGuid).HasColumnName("RegionGUID");

                entity.Property(e => e.StudyDate).HasColumnType("datetime");

                entity.Property(e => e.StudyInitSource)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyItemNames).IsRequired();

                entity.Property(e => e.StudyOperatorGuid).HasColumnName("StudyOperatorGUID");

                entity.Property(e => e.StudyStage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudyStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTypeGuid).HasColumnName("VisitTypeGUID");
            });

            modelBuilder.Entity<BackUpStudyFeeItemIndex>(entity =>
            {
                entity.ToTable("BackUpStudyFeeItemIndex");

                entity.HasIndex(e => e.BackUpGuid, "IX_BackUpStudyFeeItemIndex_BackUpGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackUpGuid).HasColumnName("BackUpGUID");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.FeeInfoGuid).HasColumnName("FeeInfoGUID");

                entity.Property(e => e.FeeInfoName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerGuid).HasColumnName("OwnerGUID");

                entity.Property(e => e.OwnerName).HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.Property(e => e.Total).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Unit).HasMaxLength(5);

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.BackUpGu)
                    .WithMany(p => p.BackUpStudyFeeItemIndices)
                    .HasForeignKey(d => d.BackUpGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BackUpStudyFeeItemIndex_BackUpStudy");
            });

            modelBuilder.Entity<BackUpStudyItemIndex>(entity =>
            {
                entity.ToTable("BackUpStudyItemIndex");

                entity.HasIndex(e => e.BackUpGuid, "IX_BackUpStudyItemIndex_BackUpGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackUpGuid).HasColumnName("BackUpGUID");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemTypeGuid).HasColumnName("ItemTypeGUID");

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.HasOne(d => d.BackUpGu)
                    .WithMany(p => p.BackUpStudyItemIndices)
                    .HasForeignKey(d => d.BackUpGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BackUpStudyItemIndex_BackUpStudy");
            });

            modelBuilder.Entity<BackUpStudyQuestFile>(entity =>
            {
                entity.ToTable("BackUpStudyQuestFile");

                entity.HasIndex(e => e.BackUpGuid, "IX_BackUpStudyQuestFile_BackUpGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackUpGuid).HasColumnName("BackUpGUID");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.OwnerGuid).HasColumnName("OwnerGUID");

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ServerPath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.BackUpGu)
                    .WithMany(p => p.BackUpStudyQuestFiles)
                    .HasForeignKey(d => d.BackUpGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BackUpStudyQuestFile_BackUpStudy");
            });

            modelBuilder.Entity<BackUpStudySchInfo>(entity =>
            {
                entity.ToTable("BackUpStudySchInfo");

                entity.HasIndex(e => e.BackUpGuid, "IX_BackUpStudySchInfo_BackUpGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackUpGuid).HasColumnName("BackUpGUID");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SchDate).HasColumnType("date");

                entity.Property(e => e.SchItemGuid).HasColumnName("SchItemGUID");

                entity.Property(e => e.SchTimeGuid).HasColumnName("SchTimeGUID");

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.HasOne(d => d.BackUpGu)
                    .WithMany(p => p.BackUpStudySchInfos)
                    .HasForeignKey(d => d.BackUpGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BackUpStudySchInfo_BackUpStudy");
            });

            modelBuilder.Entity<CallingMonitor>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("CallingMonitor");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.AutoClearTime).HasComment("呼叫信息自动清空时间");

                entity.Property(e => e.CallingTextColor)
                    .HasMaxLength(7)
                    .HasComment("呼叫信息字体颜色");

                entity.Property(e => e.CallingTextFont)
                    .HasMaxLength(50)
                    .HasComment("呼叫信息的字体样式");

                entity.Property(e => e.CallingTextSize).HasComment("呼叫信息的字体大小");

                entity.Property(e => e.DateTimeColor)
                    .HasMaxLength(7)
                    .HasComment("当前时间字体颜色");

                entity.Property(e => e.DateTimeFont)
                    .HasMaxLength(50)
                    .HasComment("当前时间字体样式");

                entity.Property(e => e.DateTimeSize).HasComment("当前时间字体大小");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("终端描述");

                entity.Property(e => e.FirstClassColumnNumber).HasDefaultValueSql("((3))");

                entity.Property(e => e.FirstClassRowNumber).HasDefaultValueSql("((10))");

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(200)
                    .HasComment("医院名称");

                entity.Property(e => e.HospitalNameColor)
                    .HasMaxLength(7)
                    .HasComment("医院名称字体颜色");

                entity.Property(e => e.HospitalNameFont)
                    .HasMaxLength(50)
                    .HasComment("医院名称字体样式");

                entity.Property(e => e.HospitalNameSize).HasComment("医院名称字体大小");

                entity.Property(e => e.MonitorNumber).HasComment("叫号屏幕数量");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("终端名称");

                entity.Property(e => e.PronounceEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("呼叫允许");

                entity.Property(e => e.PronounceFormat)
                    .HasMaxLength(200)
                    .HasComment("呼叫样式");

                entity.Property(e => e.PronounceInterval).HasComment("呼叫时间间隔");

                entity.Property(e => e.PronounceTimes)
                    .HasDefaultValueSql("((1))")
                    .HasComment("呼叫次数");

                entity.Property(e => e.QueueHeaderColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueueHeaderFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueueHeaderSize).HasDefaultValueSql("((1.0))");

                entity.Property(e => e.QueueMemberColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueueMemberFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QueueMemberSize).HasDefaultValueSql("((1.0))");

                entity.Property(e => e.ScrollingText)
                    .HasMaxLength(2000)
                    .HasComment("滚动提示信息");

                entity.Property(e => e.ScrollingTextColor)
                    .HasMaxLength(7)
                    .HasComment("滚动提示信息字体颜色");

                entity.Property(e => e.ScrollingTextFont)
                    .HasMaxLength(50)
                    .HasComment("滚动提示信息字体样式");

                entity.Property(e => e.ScrollingTextSize).HasComment("滚动提示信息字体大小");

                entity.Property(e => e.TextFormat)
                    .HasMaxLength(200)
                    .HasComment("屏幕呼叫格式");

                entity.Property(e => e.VoiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("呼叫声音样式");

                entity.Property(e => e.Volume).HasComment("音量大小");

                entity.Property(e => e.WorkstationGuid)
                    .HasColumnName("WorkstationGUID")
                    .HasComment("终端GUID");

                entity.HasOne(d => d.WorkstationGu)
                    .WithMany(p => p.CallingMonitors)
                    .HasForeignKey(d => d.WorkstationGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CallingMonitor_Workstation");
            });

            modelBuilder.Entity<CallingMonitorInfo>(entity =>
            {
                entity.ToTable("CallingMonitorInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackgroundFilePath)
                    .HasMaxLength(200)
                    .HasComment("背景图片路径");

                entity.Property(e => e.CallingTextColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('#ffffff')")
                    .HasComment("呼叫信息字体颜色");

                entity.Property(e => e.CallingTextFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("呼叫信息字体样式");

                entity.Property(e => e.CallingTextSize)
                    .HasDefaultValueSql("((1))")
                    .HasComment("呼叫信息字体大小");

                entity.Property(e => e.DateTimeColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasDefaultValueSql("(N'#ffffff')")
                    .HasComment("当前时间字体颜色");

                entity.Property(e => e.DateTimeFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("当前时间字体样式");

                entity.Property(e => e.DateTimeSize)
                    .HasDefaultValueSql("((1))")
                    .HasComment("当前时间字体大小");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("终端描述");

                entity.Property(e => e.HospitalName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("医院名称");

                entity.Property(e => e.HospitalNameColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('#ffffff')")
                    .HasComment("医院名称字体颜色");

                entity.Property(e => e.HospitalNameFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("医院名称字体样式");

                entity.Property(e => e.HospitalNameSize)
                    .HasDefaultValueSql("((1))")
                    .HasComment("医院名称字体大小");

                entity.Property(e => e.IsDefault).HasComment("是否为默认设置");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("终端名称");

                entity.Property(e => e.PronounceFormat)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .HasComment("呼叫信息格式");

                entity.Property(e => e.QueueHeaderColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasDefaultValueSql("(N'#ffffff')")
                    .HasComment("患者队列名称字体颜色");

                entity.Property(e => e.QueueHeaderFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("患者队列名称字体样式");

                entity.Property(e => e.QueueHeaderSize)
                    .HasDefaultValueSql("((1))")
                    .HasComment("患者队列名称字体大小");

                entity.Property(e => e.QueueMemberColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('#ffffff')")
                    .HasComment("患者队列字体颜色");

                entity.Property(e => e.QueueMemberFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("患者队列字体样式");

                entity.Property(e => e.QueueMemberFormat)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .HasComment("等待检查患者队列格式");

                entity.Property(e => e.QueueMemberSize)
                    .HasDefaultValueSql("((1))")
                    .HasComment("患者队列字体大小");

                entity.Property(e => e.ScrollingText)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasComment("滚动提示信息");

                entity.Property(e => e.ScrollingTextColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('#ffffff')")
                    .HasComment("滚动提示信息字体颜色");

                entity.Property(e => e.ScrollingTextFont)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("滚动提示信息字体样式");

                entity.Property(e => e.ScrollingTextSize)
                    .HasDefaultValueSql("((1))")
                    .HasComment("滚动提示信息字体大小");

                entity.Property(e => e.TextFormat)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .HasComment("呼叫信息样式");

                entity.Property(e => e.XamlSource)
                    .HasMaxLength(2000)
                    .HasComment("叫号屏幕完整Xaml");
            });

            modelBuilder.Entity<CallingMonitorQueue>(entity =>
            {
                entity.ToTable("CallingMonitorQueue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AutoPageTurningTime).HasComment("自动翻页时间");

                entity.Property(e => e.CallingMonitorGuid)
                    .HasColumnName("CallingMonitorGUID")
                    .HasComment("终端GUID");

                entity.Property(e => e.MaxColumns)
                    .HasDefaultValueSql("((1))")
                    .HasComment("最大列数");

                entity.Property(e => e.MaxQuantity)
                    .HasDefaultValueSql("((100))")
                    .HasComment("最大数量");

                entity.Property(e => e.MaxRows)
                    .HasDefaultValueSql("((10))")
                    .HasComment("最大行数");

                entity.Property(e => e.Ordered)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("队列是否排序显示（堆积显示）");

                entity.Property(e => e.QueueGuid)
                    .HasColumnName("QueueGUID")
                    .HasComment("队列GUID");

                entity.Property(e => e.QueueHeaderColor)
                    .HasMaxLength(7)
                    .HasComment("队列名称字体颜色");

                entity.Property(e => e.QueueHeaderFont)
                    .HasMaxLength(50)
                    .HasComment("队列名称字体样式");

                entity.Property(e => e.QueueHeaderSize).HasComment("队列名称字体大小");

                entity.Property(e => e.QueueMemberColor)
                    .HasMaxLength(7)
                    .HasComment("队列等待患者字体颜色");

                entity.Property(e => e.QueueMemberFont)
                    .HasMaxLength(50)
                    .HasComment("队列中等待患者字体样式");

                entity.Property(e => e.QueueMemberSize).HasComment("队列等待患者字体大小");

                entity.HasOne(d => d.CallingMonitorGu)
                    .WithMany(p => p.CallingMonitorQueues)
                    .HasForeignKey(d => d.CallingMonitorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CallingMonitorQueue_CallingMonitor");

                entity.HasOne(d => d.QueueGu)
                    .WithMany(p => p.CallingMonitorQueues)
                    .HasForeignKey(d => d.QueueGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CallingMonitorQueue_Queue");
            });

            modelBuilder.Entity<CaseRecord>(entity =>
            {
                entity.HasKey(e => e.RecNo);

                entity.ToTable("CaseRecord");

                entity.Property(e => e.AccNum)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Operator)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CategoryDetail>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("CategoryDetail");

                entity.HasIndex(e => e.CategoryTypeGuid, "IX_CategoryDetail_CategoryTypeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("归类明细GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.CategoryTypeGuid)
                    .HasColumnName("CategoryTypeGUID")
                    .HasComment("归类大类GUID");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("归类明细名称");

                entity.Property(e => e.OrderId).HasComment("排序");

                entity.HasOne(d => d.CategoryTypeGu)
                    .WithMany(p => p.CategoryDetails)
                    .HasForeignKey(d => d.CategoryTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryDetail_CategoryType");
            });

            modelBuilder.Entity<CategoryType>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("CategoryType");

                entity.HasIndex(e => e.OrderId, "IX_CategoryType_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("归类大类GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("归类大类名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");
            });

            modelBuilder.Entity<CheckItemSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CheckItemSum");

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.BakeUp)
                    .HasMaxLength(50)
                    .HasColumnName("BakeUP");

                entity.Property(e => e.CheckItemId).HasColumnName("CheckItemID");

                entity.Property(e => e.CheckItemName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ClinicianInfo>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ClinicianInfo");

                entity.HasIndex(e => e.OrderId, "IX_ClinicianInfo_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("临床医师GUID");

                entity.Property(e => e.ArrangePwd).HasMaxLength(50);

                entity.Property(e => e.ArrangeUser).HasMaxLength(50);

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("临床医师名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序号");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("首拼");

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<Column>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__Columns__A2B5777C4707859D");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OrderName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DangerKeyDic>(entity =>
            {
                entity.ToTable("DangerKeyDic");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(255)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(255)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(255)
                    .HasColumnName("BKS3");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.ItemTypeGuid).HasColumnName("ItemTypeGUID");

                entity.Property(e => e.KeyDescribe).HasMaxLength(1000);

                entity.Property(e => e.KeyName).HasMaxLength(255);

                entity.Property(e => e.KeyType).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.DangerKeyDics)
                    .HasForeignKey(d => d.ItemGuid)
                    .HasConstraintName("FK_DangerKeyDic_Item");

                entity.HasOne(d => d.ItemTypeGu)
                    .WithMany(p => p.DangerKeyDics)
                    .HasForeignKey(d => d.ItemTypeGuid)
                    .HasConstraintName("FK_DangerKeyDic_ItemType");

                entity.HasOne(d => d.ModeTypeGu)
                    .WithMany(p => p.DangerKeyDics)
                    .HasForeignKey(d => d.ModeTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangerKeyDic_ModeType");
            });

            modelBuilder.Entity<DangerKeyDicItemIndex>(entity =>
            {
                entity.ToTable("DangerKeyDicItemIndex");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DangerKeyDicId).HasColumnName("DangerKeyDicID");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.HasOne(d => d.DangerKeyDic)
                    .WithMany(p => p.DangerKeyDicItemIndices)
                    .HasForeignKey(d => d.DangerKeyDicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangerKeyDicItemIndex_Dic");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.DangerKeyDicItemIndices)
                    .HasForeignKey(d => d.ItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangerKeyDicItemIndex_Item");
            });

            modelBuilder.Entity<DangerLog>(entity =>
            {
                entity.ToTable("DangerLog");

                entity.HasIndex(e => e.StudyGuid, "IX_DangerLog_StudyGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CancelTime).HasColumnType("datetime");

                entity.Property(e => e.CancelUserId).HasColumnName("CancelUserID");

                entity.Property(e => e.DangerKeyName).HasMaxLength(1000);

                entity.Property(e => e.HandleName).HasMaxLength(100);

                entity.Property(e => e.HandleTime).HasColumnType("datetime");

                entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");

                entity.Property(e => e.SetTime).HasColumnType("datetime");

                entity.Property(e => e.SetUserGuid).HasColumnName("SetUserGUID");

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.HasOne(d => d.CancelUser)
                    .WithMany(p => p.DangerLogCancelUsers)
                    .HasForeignKey(d => d.CancelUserId)
                    .HasConstraintName("FK_DangerLog_Users_Cancel");

                entity.HasOne(d => d.PatientGu)
                    .WithMany(p => p.DangerLogs)
                    .HasForeignKey(d => d.PatientGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangerLog_Patient");

                entity.HasOne(d => d.SetUserGu)
                    .WithMany(p => p.DangerLogSetUserGus)
                    .HasForeignKey(d => d.SetUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangerLog_Users_Set");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.DangerLogs)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangerLog_Study");
            });

            modelBuilder.Entity<DataStream>(entity =>
            {
                entity.HasKey(e => e.StreamId);

                entity.ToTable("DataStream");

                entity.Property(e => e.StreamId).HasColumnName("StreamID");

                entity.Property(e => e.StreamDescription).HasMaxLength(20);

                entity.Property(e => e.StreamName).HasMaxLength(16);

                entity.Property(e => e.StreamSource).HasMaxLength(50);

                entity.Property(e => e.StreamStruct).HasMaxLength(100);

                entity.Property(e => e.StreamTarget)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DatasourceTjlxke>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Datasource_TJLXKE");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AGE");

                entity.Property(e => e.AgeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Applicationdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATIONDATE");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRTHDAY");

                entity.Property(e => e.Blh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BLH");

                entity.Property(e => e.Cardnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Clinicno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLINICNO");

                entity.Property(e => e.Danger)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DangerDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departmentguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENTGUID");

                entity.Property(e => e.Departmentname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENTNAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIAGNOSIS");

                entity.Property(e => e.Doctorcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCTORCODE");

                entity.Property(e => e.Doctorguid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCTORGUID");

                entity.Property(e => e.Doctorname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCTORNAME");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Feeitemcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEEITEMCODE");

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HEIGHT");

                entity.Property(e => e.History)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HISTORY");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDCARD");

                entity.Property(e => e.Itemcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemnamehis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNAMEHIS");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Namepinyin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAMEPINYIN");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POSTCODE");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PY");

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGION");

                entity.Property(e => e.Requestid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTID");

                entity.Property(e => e.Requirement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUIREMENT");

                entity.Property(e => e.SchDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEX");

                entity.Property(e => e.SlotTime).HasColumnType("datetime");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.Symptom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SYMPTOM");

                entity.Property(e => e.Vip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VIP");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visitnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VISITNUMBER");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("Department");

                entity.HasIndex(e => e.OrderId, "IX_Department_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("临床科室GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("科室代码");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .HasComment("说明");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("临床科室名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序号");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("科室首拼");
            });

            modelBuilder.Entity<DepartmentClinicianIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepartmentClinicianIndex");

                entity.HasIndex(e => e.DepartmentGuid, "IX_DepartmentClinicianIndex_DepartmentGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.ClinicianGuid)
                    .HasColumnName("ClinicianGUID")
                    .HasComment("医师GUID");

                entity.Property(e => e.DepartmentGuid)
                    .HasColumnName("DepartmentGUID")
                    .HasComment("科室GUID");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.HasOne(d => d.ClinicianGu)
                    .WithMany(p => p.DepartmentClinicianIndices)
                    .HasForeignKey(d => d.ClinicianGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentClinicianIndex_ClinicianInfo");

                entity.HasOne(d => d.DepartmentGu)
                    .WithMany(p => p.DepartmentClinicianIndices)
                    .HasForeignKey(d => d.DepartmentGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentClinicianIndex_Department");
            });

            modelBuilder.Entity<DepartmentRegionIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepartmentRegionIndex");

                entity.HasIndex(e => e.DepartmentGuid, "IX_DepartmentRegionIndex_DepartmentGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.DepartmentGuid)
                    .HasColumnName("DepartmentGUID")
                    .HasComment("科室GUID");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.RegionGuid)
                    .HasColumnName("RegionGUID")
                    .HasComment("病区GUID");

                entity.HasOne(d => d.DepartmentGu)
                    .WithMany(p => p.DepartmentRegionIndices)
                    .HasForeignKey(d => d.DepartmentGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentRegionIndex_Department");

                entity.HasOne(d => d.RegionGu)
                    .WithMany(p => p.DepartmentRegionIndices)
                    .HasForeignKey(d => d.RegionGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentRegionIndex_Region");
            });

            modelBuilder.Entity<DeptClass>(entity =>
            {
                entity.ToTable("DeptClass");

                entity.Property(e => e.DeptClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("DeptClassID");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.BelongPost)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("班别代码");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("班别结束时间");

                entity.Property(e => e.KeyWords).HasMaxLength(50);

                entity.Property(e => e.ModType).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.NeedStaffNum)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.OverDay)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("是否跨日");

                entity.Property(e => e.PostRules)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Remark)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("班别开始时间");
            });

            modelBuilder.Entity<DeviceInfo>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("DeviceInfo");

                entity.HasIndex(e => e.ExamRoomGuid, "IX_DeviceInfo_ExamRoomGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("设备GUID");

                entity.Property(e => e.Aetitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AETitle")
                    .HasComment("DicomAE");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .HasComment("说明");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.ExamRoomGuid)
                    .HasColumnName("ExamRoomGUID")
                    .HasComment("检查地点GUID");

                entity.Property(e => e.ExposureDefault)
                    .HasMaxLength(50)
                    .HasComment("默认曝光量");

                entity.Property(e => e.ExposureUnit)
                    .HasMaxLength(50)
                    .HasComment("曝光量单位");

                entity.Property(e => e.GuaranteeDate)
                    .HasColumnType("datetime")
                    .HasComment("质保期限");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("设备厂商");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("设备型号");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序号");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("维护电话");

                entity.HasOne(d => d.ExamRoomGu)
                    .WithMany(p => p.DeviceInfos)
                    .HasForeignKey(d => d.ExamRoomGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceInfo_ExamRoom");
            });

            modelBuilder.Entity<DyestuffPatientView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DyestuffPatientView");

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppraiseDate).HasColumnType("datetime");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.ImageNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DyestuffReportParamsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DyestuffReportParamsView");

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppraiseDate).HasColumnType("datetime");

                entity.Property(e => e.AppraisePhysician).HasMaxLength(12);

                entity.Property(e => e.Bed)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceCompany)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnosis).IsRequired();

                entity.Property(e => e.ExamName).IsRequired();

                entity.Property(e => e.FilmDate).HasColumnType("datetime");

                entity.Property(e => e.ImageNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModeName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Param1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportPhysician).HasMaxLength(12);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DyestuffReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DyestuffReportView");

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppraiseDate).HasColumnType("datetime");

                entity.Property(e => e.AppraisePhysician).HasMaxLength(12);

                entity.Property(e => e.Bed)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceCompany)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnosis).IsRequired();

                entity.Property(e => e.DoctorName).HasMaxLength(30);

                entity.Property(e => e.ExamName).IsRequired();

                entity.Property(e => e.FilmDate).HasColumnType("datetime");

                entity.Property(e => e.ImageNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModeName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Param1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.RegistryDate).HasColumnType("datetime");

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportPhysician).HasMaxLength(12);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DyestuffReportViewNk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DyestuffReportView_NK");

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppraiseDate).HasColumnType("datetime");

                entity.Property(e => e.AppraisePhysician).HasMaxLength(12);

                entity.Property(e => e.Bed)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DeviceCompany)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnosis).IsRequired();

                entity.Property(e => e.DoctorName).HasMaxLength(30);

                entity.Property(e => e.ExamName).IsRequired();

                entity.Property(e => e.FilmDate).HasColumnType("datetime");

                entity.Property(e => e.ImageNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModeName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Param1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Param2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.RegistryDate).HasColumnType("datetime");

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportPhysician).HasMaxLength(12);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DynInfo>(entity =>
            {
                entity.HasKey(e => e.InfoId);

                entity.ToTable("DynInfo");

                entity.Property(e => e.InfoId)
                    .HasMaxLength(10)
                    .HasColumnName("InfoID")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.Operator)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.OperatorContent).HasMaxLength(200);

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.OperatorType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RelationCreateTime).HasColumnType("datetime");

                entity.Property(e => e.RelationId).HasColumnName("RelationID");

                entity.Property(e => e.RelationName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TechPlanId)
                    .HasMaxLength(10)
                    .HasColumnName("TechPlanID")
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanName).HasMaxLength(20);
            });

            modelBuilder.Entity<ExamRoom>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ExamRoom");

                entity.HasIndex(e => e.OrderId, "IX_ExamRoom_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("检查地点GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .HasComment("说明");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("检查地点名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序号");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("首拼");
            });

            modelBuilder.Entity<ExamRoomModeIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ExamRoomModeIndex");

                entity.HasIndex(e => e.ModeGuid, "IX_ExamRoomModeIndex_ModeGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.ExamRoomGuid)
                    .HasColumnName("ExamRoomGUID")
                    .HasComment("检查地点GUID");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式GUID");

                entity.Property(e => e.ModeTypeGuid)
                    .HasColumnName("ModeTypeGUID")
                    .HasComment("模式大类GUID");

                entity.HasOne(d => d.ExamRoomGu)
                    .WithMany(p => p.ExamRoomModeIndices)
                    .HasForeignKey(d => d.ExamRoomGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamRoomModeIndex_ExamRoom");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.ExamRoomModeIndices)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamRoomModeIndex_Mode");

                entity.HasOne(d => d.ModeTypeGu)
                    .WithMany(p => p.ExamRoomModeIndices)
                    .HasForeignKey(d => d.ModeTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamRoomModeIndex_ModeType");
            });

            modelBuilder.Entity<ExamRoomQueue>(entity =>
            {
                entity.ToTable("ExamRoomQueue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExamRoomGuid).HasColumnName("ExamRoomGUID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.QueueGuid).HasColumnName("QueueGUID");

                entity.HasOne(d => d.ExamRoomGu)
                    .WithMany(p => p.ExamRoomQueues)
                    .HasForeignKey(d => d.ExamRoomGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamRoomQueue_ExamRoom");

                entity.HasOne(d => d.QueueGu)
                    .WithMany(p => p.ExamRoomQueues)
                    .HasForeignKey(d => d.QueueGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamRoomQueue_Queue");
            });

            modelBuilder.Entity<ExpertTemplate>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("ExpertTemplate");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.Description).HasComment("描述");

                entity.Property(e => e.Diagnosis).HasComment("诊断");

                entity.Property(e => e.IsPublic).HasComment("是否公共模板");

                entity.Property(e => e.ItemTypeGuid)
                    .HasColumnName("ItemTypeGUID")
                    .HasComment("项目大类GUID");

                entity.Property(e => e.Method).HasComment("方法");

                entity.Property(e => e.ModeTypeGuid).HasColumnName("ModeTypeGUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("模板名称");

                entity.Property(e => e.Note).HasComment("备注");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("所有者");

                entity.Property(e => e.PositiveDesc).HasComment("阳性备注");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PY")
                    .HasComment("拼首");

                entity.Property(e => e.Qualitative).HasComment("阴阳性标识");
            });

            modelBuilder.Entity<FeeInfo>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("FeeInfo");

                entity.HasIndex(e => e.ModeTypeGuid, "IX_FeeInfo_ModeTypeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Amount).HasComment("数量");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.ModeTypeGuid).HasColumnName("ModeTypeGUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("收费项目名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("单价");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("拼首");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("来源");

                entity.Property(e => e.Spec)
                    .HasMaxLength(50)
                    .HasComment("规格");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .HasComment("单位");

                entity.HasOne(d => d.ModeTypeGu)
                    .WithMany(p => p.FeeInfos)
                    .HasForeignKey(d => d.ModeTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeInfo_ModeType");
            });

            modelBuilder.Entity<FeeModeIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("FeeModeIndex");

                entity.HasIndex(e => e.ModeGuid, "IX_FeeModeIndex_ModeGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FeeInfoGuid)
                    .HasColumnName("FeeInfoGUID")
                    .HasComment("收费GUID");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式GUID");

                entity.HasOne(d => d.FeeInfoGu)
                    .WithMany(p => p.FeeModeIndices)
                    .HasForeignKey(d => d.FeeInfoGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeModeIndex_FeeInfo");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.FeeModeIndices)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FeeModeIndex_Mode");
            });

            modelBuilder.Entity<FeeType>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("FeeType");

                entity.HasIndex(e => e.OrderId, "IX_FeeType_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .HasComment("说明");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("收费类型名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序号");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("首拼");
            });

            modelBuilder.Entity<FileUpLoadRecord>(entity =>
            {
                entity.HasKey(e => e.FileUpLoadId);

                entity.ToTable("FileUpLoadRecord");

                entity.Property(e => e.FileUpLoadId)
                    .ValueGeneratedNever()
                    .HasColumnName("FileUpLoadID");

                entity.Property(e => e.FileCreator)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FileLength)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.FileUploadPath).HasMaxLength(200);

                entity.Property(e => e.FileUploadTime)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanId).HasColumnName("TechPlanID");
            });

            modelBuilder.Entity<FilmInfo>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("FilmInfo");

                entity.HasIndex(e => e.OrderId, "IX_FilmInfo_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("胶片名称");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .HasComment("备注");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");
            });

            modelBuilder.Entity<FinalReport>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_FinalReport_GUID")
                    .IsClustered(false);

                entity.ToTable("FinalReport");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.CheckOwnerGuid).HasColumnName("CheckOwnerGUID");

                entity.Property(e => e.CheckOwnerName).HasMaxLength(12);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.LastCheckOwnerGuid).HasColumnName("LastCheckOwnerGUID");

                entity.Property(e => e.LastCheckOwnerName).HasMaxLength(12);

                entity.Property(e => e.LastCheckTime).HasColumnType("datetime");

                entity.Property(e => e.LastWriteOwnerGuid).HasColumnName("LastWriteOwnerGUID");

                entity.Property(e => e.LastWriteOwnerName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.LastWriteSignaturePath).IsRequired();

                entity.Property(e => e.LastWriteTime).HasColumnType("datetime");

                entity.Property(e => e.PositiveDesc).HasMaxLength(250);

                entity.Property(e => e.ReportImages).HasMaxLength(500);

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.Property(e => e.WriteOwnerGuid).HasColumnName("WriteOwnerGUID");

                entity.Property(e => e.WriteOwnerName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.WriteSignaturePath).IsRequired();

                entity.Property(e => e.WriteTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FinalSection>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_FinalSection_GUID")
                    .IsClustered(false);

                entity.ToTable("FinalSection");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.BackUpTxt1).HasColumnType("text");

                entity.Property(e => e.BackUpTxt2).HasColumnType("text");

                entity.Property(e => e.BackUpTxt3).HasColumnType("text");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Diagnosis).IsRequired();

                entity.Property(e => e.ExamItems)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FinalReportGuid).HasColumnName("FinalReportGUID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(8);

                entity.Property(e => e.StyleGuid).HasColumnName("StyleGUID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<FollowupKey>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__Followup__15B69B8E004002F9");

                entity.ToTable("FollowupKey");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(100)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(100)
                    .HasColumnName("BKS3");

                entity.Property(e => e.KeyDescription).HasMaxLength(200);

                entity.Property(e => e.KeyName).HasMaxLength(50);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("Group");

                entity.HasIndex(e => e.OrderId, "IX_Group_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("权限组名");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasComment("备注");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GroupAccess>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("GroupAccess");

                entity.HasIndex(e => e.GroupGuid, "IX_GroupAccess_GroupGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessFunctionGuid)
                    .HasColumnName("AccessFunctionGUID")
                    .HasComment("系统功能GUID");

                entity.Property(e => e.GroupGuid)
                    .HasColumnName("GroupGUID")
                    .HasComment("组GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.GroupGu)
                    .WithMany(p => p.GroupAccesses)
                    .HasForeignKey(d => d.GroupGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAccess_Group");
            });

            modelBuilder.Entity<GroupUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.GroupGuid, "IX_GroupUsers_GroupGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupGuid)
                    .HasColumnName("GroupGUID")
                    .HasComment("组GUID");

                entity.Property(e => e.UsersGuid)
                    .HasColumnName("UsersGUID")
                    .HasComment("用户GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.GroupGu)
                    .WithMany(p => p.GroupUsers)
                    .HasForeignKey(d => d.GroupGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUsers_Group");

                entity.HasOne(d => d.UsersGu)
                    .WithMany(p => p.GroupUsers)
                    .HasForeignKey(d => d.UsersGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUsers_Users");
            });

            modelBuilder.Entity<HospitalInfo>(entity =>
            {
                entity.ToTable("HospitalInfo");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("内部ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasComment("地址");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("医院编号");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasComment("传真号");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(50)
                    .HasComment("Logo图片地址");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("医院名称");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasComment("电话");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .HasComment("邮编");
            });

            modelBuilder.Entity<Icdcode>(entity =>
            {
                entity.ToTable("ICDCode");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<InterMessage>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("InterMessage");

                entity.HasIndex(e => e.SentTime, "IX_InterMessage_SentTime")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasComment("消息GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasComment("内容");

                entity.Property(e => e.IsExpired).HasComment("是否失效");

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .HasComment("链接");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("发送者姓名");

                entity.Property(e => e.SenderUserGuid)
                    .HasColumnName("SenderUserGUID")
                    .HasComment("发送者GUID");

                entity.Property(e => e.SentTime)
                    .HasColumnType("datetime")
                    .HasComment("发送时间");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("标题");

                entity.HasOne(d => d.SenderUserGu)
                    .WithMany(p => p.InterMessages)
                    .HasForeignKey(d => d.SenderUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterMessage_Users");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("Item");

                entity.HasIndex(e => new { e.ModeTypeGuid, e.ItemTypeGuid }, "IX_Item_ModeTypeGUID_ItemTypeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.ExamRoomList).HasMaxLength(1000);

                entity.Property(e => e.FilmGuid)
                    .HasColumnName("FilmGUID")
                    .HasComment("胶片GUID");

                entity.Property(e => e.FilmNum).HasComment("胶片数量");

                entity.Property(e => e.Isdefault).HasComment("是否默认");

                entity.Property(e => e.ItemTypeGuid)
                    .HasColumnName("ItemTypeGUID")
                    .HasComment("项目大类GUID");

                entity.Property(e => e.ModeTypeGuid)
                    .HasColumnName("ModeTypeGUID")
                    .HasComment("模式大类GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("拼首");

                entity.Property(e => e.ReportTime).HasComment("出报告时间间隔");

                entity.Property(e => e.SplitFlag).HasComment("是否拆分");

                entity.Property(e => e.Weight)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("项目权重");

                entity.HasOne(d => d.FilmGu)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.FilmGuid)
                    .HasConstraintName("FK_Item_FilmInfo");

                entity.HasOne(d => d.ItemTypeGu)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ItemType");

                entity.HasOne(d => d.ModeTypeGu)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ModeTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_ModeType");
            });

            modelBuilder.Entity<ItemDiagFilter>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ItemDiagFilter");

                entity.HasIndex(e => e.ItemGuid, "IX_ItemDiagFilter_ItemGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasComment("项目GUID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("过滤内容");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.ItemDiagFilters)
                    .HasForeignKey(d => d.ItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemDiagFilter_Item");
            });

            modelBuilder.Entity<ItemDicomInfo>(entity =>
            {
                entity.ToTable("ItemDicomInfo");

                entity.HasIndex(e => new { e.DeviceGuid, e.ItemGuid }, "IX_ItemDicomInfo_DeviceGUID_ItemGUID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.DeviceGuid)
                    .HasColumnName("DeviceGUID")
                    .HasComment("设备GUID");

                entity.Property(e => e.DicomCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("设备DICOM代码");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasComment("项目GUID");

                entity.HasOne(d => d.DeviceGu)
                    .WithMany(p => p.ItemDicomInfos)
                    .HasForeignKey(d => d.DeviceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemDicomInfo_DeviceInfo");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.ItemDicomInfos)
                    .HasForeignKey(d => d.ItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemDicomInfo_Item");
            });

            modelBuilder.Entity<ItemFeeIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ItemFeeIndex");

                entity.HasIndex(e => e.ItemGuid, "IX_ItemFeeIndex_ItemGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FeeGuid)
                    .HasColumnName("FeeGUID")
                    .HasComment("收费GUID");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasComment("项目GUID");

                entity.HasOne(d => d.FeeGu)
                    .WithMany(p => p.ItemFeeIndices)
                    .HasForeignKey(d => d.FeeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemFeeIndex_FeeInfo");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.ItemFeeIndices)
                    .HasForeignKey(d => d.ItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemFeeIndex_Item");
            });

            modelBuilder.Entity<ItemModeIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ItemModeIndex");

                entity.HasIndex(e => e.ModeGuid, "IX_ItemModeIndex_ModeGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasComment("项目GUID");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式GUID");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.ItemModeIndices)
                    .HasForeignKey(d => d.ItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemModeIndex_Item");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.ItemModeIndices)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemModeIndex_Mode");
            });

            modelBuilder.Entity<ItemSplitDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ItemSplitDetail");

                entity.HasIndex(e => e.ItemGuid, "IX_ItemSplitDetail_ItemGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasComment("主项目GUID");

                entity.Property(e => e.ItemSplitGuid)
                    .HasColumnName("ItemSplitGUID")
                    .HasComment("拆分项目GUID");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.ItemSplitDetailItemGus)
                    .HasForeignKey(d => d.ItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemSplitDetail_Item");

                entity.HasOne(d => d.ItemSplitGu)
                    .WithMany(p => p.ItemSplitDetailItemSplitGus)
                    .HasForeignKey(d => d.ItemSplitGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemSplitDetail_Item_Split");
            });

            modelBuilder.Entity<ItemTemplate>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ItemTemplate");

                entity.HasIndex(e => e.ItemGuid, "IX_ItemTemplate_ItemGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasComment("项目GUID");

                entity.Property(e => e.TemplateGuid)
                    .HasColumnName("TemplateGUID")
                    .HasComment("模板GUID");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ItemType");

                entity.HasIndex(e => e.OrderId, "IX_ItemType_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("项目大类名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("首拼");
            });

            modelBuilder.Entity<ItemTypeExpert>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ItemTypeExpert");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("代码");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("项目大类名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.Py)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PY")
                    .HasComment("首拼");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("MenuItem");

                entity.HasIndex(e => e.ParentGuid, "IX_MenuItem_ParentGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("菜单代码");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("菜单链接");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("菜单名称");

                entity.Property(e => e.OrderCode).HasComment("序号");

                entity.Property(e => e.ParentGuid)
                    .HasColumnName("ParentGUID")
                    .HasComment("父级菜单号");
            });

            modelBuilder.Entity<Mod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MOD");

                entity.Property(e => e.Cname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNAME");

                entity.Property(e => e.Discription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISCRIPTION");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Reporttype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REPORTTYPE");

                entity.Property(e => e.Templatename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TEMPLATENAME");
            });

            modelBuilder.Entity<Mode>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("Mode");

                entity.HasIndex(e => e.ModeTypeGuid, "IX_Mode_ModeTypeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.AccnumPrefix)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("摄片号前缀");

                entity.Property(e => e.AccnumSuffix)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("摄片号后缀");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("模式代号");

                entity.Property(e => e.Discription)
                    .HasMaxLength(50)
                    .HasComment("备注");

                entity.Property(e => e.Enabled).HasComment("是否启用");

                entity.Property(e => e.ModeTypeGuid)
                    .HasColumnName("ModeTypeGUID")
                    .HasComment("模式大类GUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.TimeoutFlag)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否检查超时提醒");

                entity.HasOne(d => d.ModeTypeGu)
                    .WithMany(p => p.Modes)
                    .HasForeignKey(d => d.ModeTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mode_ModeType");
            });

            modelBuilder.Entity<ModeType>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ModeType");

                entity.HasIndex(e => e.OrderId, "IX_ModeType_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("模式大类代号");

                entity.Property(e => e.Discription)
                    .HasMaxLength(50)
                    .HasComment("备注");

                entity.Property(e => e.HisFeeCode).HasMaxLength(50);

                entity.Property(e => e.HisPerformedDeptCode)
                    .HasMaxLength(50)
                    .HasComment("HIS对应代码");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("序号");
            });

            modelBuilder.Entity<ModeTypeExpert>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("ModeTypeExpert");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("模式大类代号");

                entity.Property(e => e.Discription)
                    .HasMaxLength(50)
                    .HasComment("备注");

                entity.Property(e => e.HisFeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HisPerformedDeptCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("HIS对应代码");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("序号");
            });

            modelBuilder.Entity<NumberSeed>(entity =>
            {
                entity.ToTable("NumberSeed");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NumType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pathological>(entity =>
            {
                entity.HasKey(e => new { e.Aid, e.Pid })
                    .IsClustered(false);

                entity.ToTable("Pathological");

                entity.HasIndex(e => e.Aid, "IX_Pathological_Aid")
                    .IsClustered();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_EN");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.Pathologicals)
                    .HasForeignKey(d => d.Aid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pathological_Anotomical");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_Patient_GUID")
                    .IsClustered(false);

                entity.ToTable("Patient");

                entity.HasIndex(e => e.Name, "IX_Patient_PName")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("病人ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasComment("地址");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasComment("出生日期");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Blh)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BLH")
                    .HasComment("病历号");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("邮件");

                entity.Property(e => e.Height)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("身高");

                entity.Property(e => e.HisPidStr).HasMaxLength(50);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("IDCard")
                    .HasComment("身份证");

                entity.Property(e => e.ImgId).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasComment("姓名");

                entity.Property(e => e.NamePinYin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("全拼");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("电话");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("邮编");

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("拼首");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("性别");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Vip)
                    .HasColumnName("VIP")
                    .HasComment("VIP标识");

                entity.Property(e => e.Weight)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("体重");

                entity.Property(e => e.Ybkh)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("YBKH")
                    .HasComment("医保卡号");
            });

            modelBuilder.Entity<PatientExtra>(entity =>
            {
                entity.HasKey(e => new { e.PatientGuid, e.Field })
                    .IsClustered(false);

                entity.ToTable("PatientExtra");

                entity.HasIndex(e => e.PatientGuid, "IX_PatientExtra_PatientGUID")
                    .IsClustered();

                entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");

                entity.Property(e => e.Field).HasMaxLength(32);

                entity.Property(e => e.Value).HasMaxLength(1000);

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.PatientGu)
                    .WithMany(p => p.PatientExtras)
                    .HasForeignKey(d => d.PatientGuid)
                    .HasConstraintName("FK__PatientEx__Patient");
            });

            modelBuilder.Entity<PatientVip>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("PatientVIP");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Birthday)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Bkb)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("BKS3");

                entity.Property(e => e.Blh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BLH");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.NamePinYin)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");

                entity.Property(e => e.Phone).HasMaxLength(500);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("PY");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ybkh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("YBKH");

                entity.HasOne(d => d.PatientGu)
                    .WithMany(p => p.PatientVips)
                    .HasForeignKey(d => d.PatientGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientVIP_Patient");
            });

            modelBuilder.Entity<PostSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PostSum");

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.PostCreateTime).HasColumnType("datetime");

                entity.Property(e => e.PostEffective)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PostGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.PostName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Uivisible)
                    .HasMaxLength(50)
                    .HasColumnName("UIVisible");
            });

            modelBuilder.Entity<QualityControlDetail>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__QualityC__A2B5777C2665ABE1");

                entity.ToTable("QualityControlDetail");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.Bkb)
                    .HasMaxLength(50)
                    .HasColumnName("BKB");

                entity.Property(e => e.Bki)
                    .HasMaxLength(50)
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks)
                    .HasMaxLength(50)
                    .HasColumnName("BKS");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(50)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(50)
                    .HasColumnName("BKS3");

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.OperationTime).HasColumnType("datetime");

                entity.HasOne(d => d.QualityControlMonthGu)
                    .WithMany(p => p.QualityControlDetails)
                    .HasForeignKey(d => d.QualityControlMonthGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detail_YearMonth");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.QualityControlDetails)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detail_Study");
            });

            modelBuilder.Entity<QualityControlInfo>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__QualityC__A2B5777C1EC48A19");

                entity.ToTable("QualityControlInfo");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<QualityControlLog>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__QualityC__A2B5777C2A363CC5");

                entity.ToTable("QualityControlLog");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.Bkb)
                    .HasMaxLength(50)
                    .HasColumnName("BKB");

                entity.Property(e => e.Bki)
                    .HasMaxLength(50)
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks)
                    .HasMaxLength(50)
                    .HasColumnName("BKS");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(50)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(50)
                    .HasColumnName("BKS3");

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.OperationTime).HasColumnType("datetime");

                entity.HasOne(d => d.QualityControlDetailGu)
                    .WithMany(p => p.QualityControlLogs)
                    .HasForeignKey(d => d.QualityControlDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Detail");
            });

            modelBuilder.Entity<QualityControlMonth>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__QualityC__A2B5777C22951AFD");

                entity.ToTable("QualityControlMonth");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.Bkb)
                    .HasMaxLength(50)
                    .HasColumnName("BKB");

                entity.Property(e => e.Bki)
                    .HasMaxLength(50)
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks)
                    .HasMaxLength(50)
                    .HasColumnName("BKS");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(50)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(50)
                    .HasColumnName("BKS3");

                entity.Property(e => e.LastOperationTime).HasColumnType("datetime");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.YearMonth).HasColumnType("datetime");
            });

            modelBuilder.Entity<Queue>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("Queue");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QueueContainerDb>(entity =>
            {
                entity.HasKey(e => e.ContainerGuid)
                    .HasName("PK_QueueContainer");

                entity.ToTable("QueueContainerDB");

                entity.Property(e => e.ContainerGuid)
                    .ValueGeneratedNever()
                    .HasColumnName("ContainerGUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Members).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("Region");

                entity.HasIndex(e => e.OrderId, "IX_Region_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("病区GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("病区代码");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .HasComment("说明");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("病区名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序号");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("病区首拼");
            });

            modelBuilder.Entity<RelationSum>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("RelationSum");

                entity.Property(e => e.AutoId).HasColumnName("AutoID");

                entity.Property(e => e.RelationEnglishName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RelationName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_Report_GUID")
                    .IsClustered(false);

                entity.ToTable("Report");

                entity.HasIndex(e => e.StudyGuid, "IX_Report_StudyGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.CheckOwnerGuid)
                    .HasColumnName("CheckOwnerGUID")
                    .HasComment("审核医生ID");

                entity.Property(e => e.CheckOwnerName)
                    .HasMaxLength(12)
                    .HasComment("审核医生名称");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasComment("审核时间");

                entity.Property(e => e.DraftTag).HasComment("正副本标识");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OrderID");

                entity.Property(e => e.PositiveDesc)
                    .HasMaxLength(250)
                    .HasComment("阳性描述");

                entity.Property(e => e.Qualitative).HasComment("阴阳定性");

                entity.Property(e => e.RelatedReportId)
                    .HasColumnName("RelatedReportID")
                    .HasComment("初写报告ID");

                entity.Property(e => e.ReportImages).HasMaxLength(500);

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查ID");

                entity.Property(e => e.StyleGuid)
                    .HasColumnName("StyleGUID")
                    .HasComment("报告样式ID");

                entity.Property(e => e.Type).HasComment("报告状态");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WriteOwnerGuid)
                    .HasColumnName("WriteOwnerGUID")
                    .HasComment("报告医生ID");

                entity.Property(e => e.WriteOwnerName)
                    .HasMaxLength(12)
                    .HasComment("报告医生姓名");

                entity.Property(e => e.WriteTime)
                    .HasColumnType("datetime")
                    .HasComment("报告时间");

                entity.HasOne(d => d.CheckOwnerGu)
                    .WithMany(p => p.ReportCheckOwnerGus)
                    .HasForeignKey(d => d.CheckOwnerGuid)
                    .HasConstraintName("FK_Report_Users_CheckGUID");

                entity.HasOne(d => d.RelatedReport)
                    .WithMany(p => p.InverseRelatedReport)
                    .HasForeignKey(d => d.RelatedReportId)
                    .HasConstraintName("FK_Report_Report");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Study");

                entity.HasOne(d => d.StyleGu)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.StyleGuid)
                    .HasConstraintName("FK_Report_Style");

                entity.HasOne(d => d.WriteOwnerGu)
                    .WithMany(p => p.ReportWriteOwnerGus)
                    .HasForeignKey(d => d.WriteOwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Users_WriteGUID");
            });

            modelBuilder.Entity<ReportGradeInfo>(entity =>
            {
                entity.ToTable("ReportGradeInfo");

                entity.HasIndex(e => e.ReportGuid, "IX_ReportGradeInfo_ReportGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ReportGrade).HasComment("报告评价");

                entity.Property(e => e.ReportGradeDate)
                    .HasColumnType("datetime")
                    .HasComment("评级时间");

                entity.Property(e => e.ReportGradeNote)
                    .HasMaxLength(150)
                    .HasComment("评级原因");

                entity.Property(e => e.ReportGradeOwnerGuid)
                    .HasColumnName("ReportGradeOwnerGUID")
                    .HasComment("评级者");

                entity.Property(e => e.ReportGuid).HasColumnName("ReportGUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ReportGradeOwnerGu)
                    .WithMany(p => p.ReportGradeInfos)
                    .HasForeignKey(d => d.ReportGradeOwnerGuid)
                    .HasConstraintName("FK_ReportGradeInfo_Users");

                entity.HasOne(d => d.ReportGu)
                    .WithMany(p => p.ReportGradeInfos)
                    .HasForeignKey(d => d.ReportGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportGradeInfo_Report");
            });

            modelBuilder.Entity<RightManage>(entity =>
            {
                entity.HasKey(e => e.RightId);

                entity.ToTable("RightManage");

                entity.Property(e => e.RightId)
                    .ValueGeneratedNever()
                    .HasColumnName("RightID");

                entity.Property(e => e.ForCollections).HasMaxLength(50);

                entity.Property(e => e.RightDescription).HasMaxLength(50);

                entity.Property(e => e.RightName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RightOperate).HasMaxLength(50);
            });

            modelBuilder.Entity<RolePost>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("RolePost");

                entity.HasIndex(e => e.OrderId, "IX_RolePost_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("序号");

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("首拼");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_Section_GUID")
                    .IsClustered(false);

                entity.ToTable("Section");

                entity.HasIndex(e => e.ReportGuid, "IX_Section_ReportGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("GUID");

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.BackUpTxt1).HasColumnType("text");

                entity.Property(e => e.BackUpTxt2).HasColumnType("text");

                entity.Property(e => e.BackUpTxt3).HasColumnType("text");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasComment("放射学表现");

                entity.Property(e => e.Diagnosis)
                    .IsRequired()
                    .HasComment("放射学诊断");

                entity.Property(e => e.ExamItems)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasComment("报告检查名称");

                entity.Property(e => e.Method).HasComment("检查方法");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Note).HasComment("报告备注");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("序号");

                entity.Property(e => e.ReportGuid).HasColumnName("ReportGUID");

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.StyleGuid).HasColumnName("StyleGUID");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ReportGu)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.ReportGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Section_Report");

                entity.HasOne(d => d.StyleGu)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.StyleGuid)
                    .HasConstraintName("FK_Section_Style");
            });

            modelBuilder.Entity<SectionExtra>(entity =>
            {
                entity.HasKey(e => new { e.SectionGuid, e.Field })
                    .IsClustered(false);

                entity.ToTable("SectionExtra");

                entity.Property(e => e.SectionGuid).HasColumnName("SectionGUID");

                entity.Property(e => e.Field).HasMaxLength(32);

                entity.Property(e => e.Value).HasMaxLength(1000);

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SectionGu)
                    .WithMany(p => p.SectionExtras)
                    .HasForeignKey(d => d.SectionGuid)
                    .HasConstraintName("FK__SectionExtr__Section");
            });

            modelBuilder.Entity<ShiftDate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.AutorId)
                    .HasMaxLength(10)
                    .HasColumnName("AutorID")
                    .IsFixedLength(true);

                entity.Property(e => e.BelongPost)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .HasColumnName("GroupID");

                entity.Property(e => e.OperatoType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftDate1)
                    .HasMaxLength(10)
                    .HasColumnName("ShiftDate")
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftEndDate)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ShiftManage>(entity =>
            {
                entity.ToTable("ShiftManage");

                entity.Property(e => e.ShiftManageId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShiftManageID");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.DeptClassId)
                    .HasMaxLength(10)
                    .HasColumnName("DeptClassID")
                    .IsFixedLength(true)
                    .HasComment("对应的是DeptClass表的DeptCode");

                entity.Property(e => e.EffectEndTime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EffectStartTime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .HasColumnName("GroupID");

                entity.Property(e => e.Permission).HasMaxLength(200);

                entity.Property(e => e.ShiftDate).HasColumnType("date");

                entity.Property(e => e.ShiftManageName).HasMaxLength(50);

                entity.Property(e => e.StaffId)
                    .HasMaxLength(200)
                    .HasColumnName("StaffID")
                    .HasComment("对应BelongPost");

                entity.Property(e => e.StaffNames).HasMaxLength(500);
            });

            modelBuilder.Entity<ShiftManageN>(entity =>
            {
                entity.HasKey(e => e.ShiftManageId);

                entity.ToTable("ShiftManageN");

                entity.Property(e => e.ShiftManageId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShiftManageID")
                    .HasComment("排班唯一ID");

                entity.Property(e => e.AuthorId)
                    .HasMaxLength(10)
                    .HasColumnName("AuthorID")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.DeptClassId)
                    .HasMaxLength(10)
                    .HasColumnName("DeptClassID")
                    .IsFixedLength(true);

                entity.Property(e => e.SatffId)
                    .HasMaxLength(10)
                    .HasColumnName("SatffID")
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftDate)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftManageName)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("排班记录名称(如李振华1月10日排班)");
            });

            modelBuilder.Entity<ShiftManageView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ShiftManage_View");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EffectEndTime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EffectStartTime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .HasColumnName("GroupID");

                entity.Property(e => e.ShiftDate).HasColumnType("date");

                entity.Property(e => e.ShiftManageName).HasMaxLength(50);

                entity.Property(e => e.StaffId)
                    .HasMaxLength(200)
                    .HasColumnName("StaffID");

                entity.Property(e => e.StaffNames).HasMaxLength(500);
            });

            modelBuilder.Entity<Shiftdeptstaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftdeptstaff");

                entity.Property(e => e.BelongPost)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DeptClassId)
                    .HasMaxLength(10)
                    .HasColumnName("DeptClassID")
                    .IsFixedLength(true);

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EffectStartTime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .HasColumnName("GroupID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.NeedStaffNum)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftDate).HasColumnType("date");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(200)
                    .HasColumnName("StaffID");

                entity.Property(e => e.StaffNames).HasMaxLength(500);

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<Shiftdeptstaff1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftdeptstaffs");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BelongPost)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DeptClassId)
                    .HasMaxLength(10)
                    .HasColumnName("DeptClassID")
                    .IsFixedLength(true);

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .HasColumnName("GroupID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.NeedStaffNum)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.OverDay)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Permission)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftDate).HasColumnType("date");

                entity.Property(e => e.ShiftManageId).HasColumnName("ShiftManageID");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(200)
                    .HasColumnName("StaffID");

                entity.Property(e => e.Staffname).HasMaxLength(20);

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<SmartprintGetimagedatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SMARTPRINT_GETIMAGEDATA");

                entity.Property(e => e.Accnum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCNUM");

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AGE");

                entity.Property(e => e.Approvedate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPROVEDATE");

                entity.Property(e => e.Approvedoctor)
                    .HasMaxLength(12)
                    .HasColumnName("APPROVEDOCTOR");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Blkh)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BLKH");

                entity.Property(e => e.Examdevice)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EXAMDEVICE");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("IDCARD");

                entity.Property(e => e.Jclx)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("JCLX");

                entity.Property(e => e.Jzkh)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("JZKH");

                entity.Property(e => e.Modality)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("MODALITY");

                entity.Property(e => e.Orderdepartment)
                    .HasMaxLength(30)
                    .HasColumnName("ORDERDEPARTMENT");

                entity.Property(e => e.Orderdoctor)
                    .HasMaxLength(30)
                    .HasColumnName("ORDERDOCTOR");

                entity.Property(e => e.Patientid).HasColumnName("PATIENTID");

                entity.Property(e => e.Pdfreporturl)
                    .HasMaxLength(4000)
                    .HasColumnName("PDFREPORTURL");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("PNAME");

                entity.Property(e => e.Pnamepy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNAMEPY");

                entity.Property(e => e.Reportdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REPORTDATE");

                entity.Property(e => e.Reportdignosis).HasColumnName("REPORTDIGNOSIS");

                entity.Property(e => e.Reportdoctor)
                    .HasMaxLength(12)
                    .HasColumnName("REPORTDOCTOR");

                entity.Property(e => e.Reportfinding).HasColumnName("REPORTFINDING");

                entity.Property(e => e.Reportmethod).HasColumnName("REPORTMETHOD");

                entity.Property(e => e.Reportnote).HasColumnName("REPORTNOTE");

                entity.Property(e => e.Reportstatus).HasColumnName("REPORTSTATUS");

                entity.Property(e => e.Rks)
                    .HasMaxLength(30)
                    .HasColumnName("RKS");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEX")
                    .IsFixedLength(true);

                entity.Property(e => e.Studydate)
                    .HasColumnType("datetime")
                    .HasColumnName("STUDYDATE");

                entity.Property(e => e.Studyitem)
                    .IsRequired()
                    .HasColumnName("STUDYITEM");

                entity.Property(e => e.Ybkh)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("YBKH");
            });

            modelBuilder.Entity<StaffPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StaffPost");

                entity.Property(e => e.BelongPost)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Permission)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PostName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftNums).HasMaxLength(50);

                entity.Property(e => e.StaffId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("StaffID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StationColumn>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__StationC__A2B5777C4AD81681");

                entity.ToTable("StationColumn");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EnglishName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OrderName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Study>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_Study_GUID")
                    .IsClustered(false);

                entity.ToTable("Study");

                entity.HasIndex(e => e.AccNum, "IX_Study_AccNum")
                    .IsUnique();

                entity.HasIndex(e => e.ModeName, "IX_Study_ModeName")
                    .IsClustered();

                entity.HasIndex(e => e.PatientGuid, "IX_Study_PatientGUID");

                entity.HasIndex(e => e.RegDate, "IX_Study_RegDate");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("检查ID");

                entity.Property(e => e.AccNum)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("摄片序号");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("条码号");

                entity.Property(e => e.BedNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("病床号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(200)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(200)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.CliniAge)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasComment("临床检查年龄");

                entity.Property(e => e.CliniAgeUnit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasComment("年龄单位");

                entity.Property(e => e.CliniBodyDescription).HasComment("临床体征");

                entity.Property(e => e.CliniDeptGuid)
                    .HasColumnName("CliniDeptGUID")
                    .HasComment("申请科室ID");

                entity.Property(e => e.CliniDiagnosis).HasComment("临床诊断");

                entity.Property(e => e.CliniDoctorGuid)
                    .HasColumnName("CliniDoctorGUID")
                    .HasComment("申请医生ID");

                entity.Property(e => e.CliniHistoryDes).HasComment("临床病史");

                entity.Property(e => e.CliniItem)
                    .HasMaxLength(200)
                    .HasComment("临床申请项目");

                entity.Property(e => e.CliniRequestId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("临床申请号");

                entity.Property(e => e.CliniStudyDate)
                    .HasColumnType("datetime")
                    .HasComment("申请时间");

                entity.Property(e => e.CliniStudyDesc).HasComment("送检要求");

                entity.Property(e => e.CliniSymptom).HasComment("临床症状");

                entity.Property(e => e.Comment).HasComment("检查登记备注");

                entity.Property(e => e.DailySequence).HasMaxLength(20);

                entity.Property(e => e.Danger).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstimateCompleteDate)
                    .HasColumnType("datetime")
                    .HasComment("检查预估完成时间");

                entity.Property(e => e.FeeTypeGuid)
                    .HasColumnName("FeeTypeGUID")
                    .HasComment("费用类型ID");

                entity.Property(e => e.ImgFlag).HasComment("影像到达标识");

                entity.Property(e => e.InitState).HasComment("初始状态");

                entity.Property(e => e.IsFilmFlag).HasComment("胶片标识");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式ID");

                entity.Property(e => e.ModeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("模式名称");

                entity.Property(e => e.PaperPrintFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaperPrintNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientGuid)
                    .HasColumnName("PatientGUID")
                    .HasComment("病人ID");

                entity.Property(e => e.PrintFilmState).HasComment("胶片打印状态");

                entity.Property(e => e.ReferAccnum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("附属摄片序号");

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasComment("登记时间");

                entity.Property(e => e.RegOperatorGuid)
                    .HasColumnName("RegOperatorGUID")
                    .HasComment("登记者ID");

                entity.Property(e => e.RegionGuid)
                    .HasColumnName("RegionGUID")
                    .HasComment("病区ID");

                entity.Property(e => e.ReportPrintFlag).HasComment("报告打印标识");

                entity.Property(e => e.ReportPrintNum).HasComment("报告打印次数");

                entity.Property(e => e.ScanFlag).HasComment("扫描标识");

                entity.Property(e => e.SplitFlag).HasComment("拆分标识");

                entity.Property(e => e.StudyDate)
                    .HasColumnType("datetime")
                    .HasComment("检查时间");

                entity.Property(e => e.StudyInitSource)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("检查来源");

                entity.Property(e => e.StudyItemNames)
                    .IsRequired()
                    .HasComment("项目大类名称");

                entity.Property(e => e.StudyOperatorGuid)
                    .HasColumnName("StudyOperatorGUID")
                    .HasComment("检查者ID");

                entity.Property(e => e.Urgent).HasComment("加急标识");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Vip).HasDefaultValueSql("((0))");

                entity.Property(e => e.VisitNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("检查登记号");

                entity.Property(e => e.VisitTypeGuid)
                    .HasColumnName("VisitTypeGUID")
                    .HasComment("检查类型ID");

                entity.HasOne(d => d.CliniDeptGu)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.CliniDeptGuid)
                    .HasConstraintName("FK_Study_Department");

                entity.HasOne(d => d.CliniDoctorGu)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.CliniDoctorGuid)
                    .HasConstraintName("FK_Study_ClinicianInfo");

                entity.HasOne(d => d.FeeTypeGu)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.FeeTypeGuid)
                    .HasConstraintName("FK_Study_FeeType");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Study_Mode");

                entity.HasOne(d => d.PatientGu)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.PatientGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Study_Patient");

                entity.HasOne(d => d.RegOperatorGu)
                    .WithMany(p => p.StudyRegOperatorGus)
                    .HasForeignKey(d => d.RegOperatorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Study_Users");

                entity.HasOne(d => d.RegionGu)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.RegionGuid)
                    .HasConstraintName("FK_Study_Region");

                entity.HasOne(d => d.StudyOperatorGu)
                    .WithMany(p => p.StudyStudyOperatorGus)
                    .HasForeignKey(d => d.StudyOperatorGuid)
                    .HasConstraintName("FK_Study_Users_StudyOperator");

                entity.HasOne(d => d.VisitTypeGu)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.VisitTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Study_VisitType");
            });

            modelBuilder.Entity<StudyAcrindex>(entity =>
            {
                entity.ToTable("StudyACRIndex");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyACRIndex_StudyGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnotomicalCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PathologicalCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyAcrindices)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyACRIndex_Study");
            });

            modelBuilder.Entity<StudyCategoryIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("StudyCategoryIndex");

                entity.HasIndex(e => e.CategoryDetailGuid, "IX_StudyCategoryIndex_CategoryDetailGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.CategoryDetailGuid)
                    .HasColumnName("CategoryDetailGUID")
                    .HasComment("归类GUID");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.HasOne(d => d.CategoryDetailGu)
                    .WithMany(p => p.StudyCategoryIndices)
                    .HasForeignKey(d => d.CategoryDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyCategoryIndex_CategoryDetail");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyCategoryIndices)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyCategoryIndex_Study");
            });

            modelBuilder.Entity<StudyDiagnoseQuality>(entity =>
            {
                entity.ToTable("StudyDiagnoseQuality");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Acrcode)
                    .HasMaxLength(50)
                    .HasColumnName("ACRCode");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ChemicalExam).HasComment("化验所见");

                entity.Property(e => e.CoincidenceFlag).HasComment("符合率");

                entity.Property(e => e.ConsistenceFlag).HasComment("一致性");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Icdcode)
                    .HasMaxLength(50)
                    .HasColumnName("ICDCode");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComment("随访时间");

                entity.Property(e => e.OperateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("随访医生");

                entity.Property(e => e.Pathology).HasComment("病理所见");

                entity.Property(e => e.RadiateExam).HasComment("放射所见");

                entity.Property(e => e.Sdqtype).HasColumnName("SDQType");

                entity.Property(e => e.SeeFromOperation).HasComment("术检所见");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.StudyDiagnoseQualityOwnerGus)
                    .HasForeignKey(d => d.OwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyDiagnoseQuality_Users");

                entity.HasOne(d => d.PatientGu)
                    .WithMany(p => p.StudyDiagnoseQualityPatientGus)
                    .HasForeignKey(d => d.PatientGuid)
                    .HasConstraintName("FK_StudyDiagnoseQuality_Patient");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyDiagnoseQualities)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyDiagnoseQuality_Study");
            });

            modelBuilder.Entity<StudyDiagnoseQualityLog>(entity =>
            {
                entity.ToTable("StudyDiagnoseQualityLog");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.AccNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Acrcode)
                    .HasMaxLength(50)
                    .HasColumnName("ACRCode");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ChemicalExam).HasComment("化验所见");

                entity.Property(e => e.CoincidenceFlag).HasComment("符合率");

                entity.Property(e => e.Comment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConsistenceFlag).HasComment("一致性");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComment("随访时间");

                entity.Property(e => e.OperateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("随访医生");

                entity.Property(e => e.Pathology).HasComment("病理所见");

                entity.Property(e => e.RadiateExam).HasComment("放射所见");

                entity.Property(e => e.Sdqid).HasColumnName("SDQID");

                entity.Property(e => e.Sdqtype).HasColumnName("SDQType");

                entity.Property(e => e.SeeFromOperation).HasComment("术检所见");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.StudyDiagnoseQualityLogs)
                    .HasForeignKey(d => d.OwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyDiagnoseQualityLog_Users");

                entity.HasOne(d => d.Sdq)
                    .WithMany(p => p.StudyDiagnoseQualityLogs)
                    .HasForeignKey(d => d.Sdqid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyDiagnoseQualityLog_StudyDiagnoseQuality");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyDiagnoseQualityLogs)
                    .HasForeignKey(d => d.StudyGuid)
                    .HasConstraintName("FK_StudyDiagnoseQualityLog_Study");
            });

            modelBuilder.Entity<StudyExtra>(entity =>
            {
                entity.HasKey(e => new { e.StudyGuid, e.Field })
                    .IsClustered(false);

                entity.ToTable("StudyExtra");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyExtra_StudyGUID");

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.Property(e => e.Field).HasMaxLength(32);

                entity.Property(e => e.Value).HasMaxLength(1000);

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyExtras)
                    .HasForeignKey(d => d.StudyGuid)
                    .HasConstraintName("FK__StudyExtr__Study");
            });

            modelBuilder.Entity<StudyFeeItemIndex>(entity =>
            {
                entity.ToTable("StudyFeeItemIndex");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyFeeItemIndex_StudyGUID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Amount).HasComment("数量");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.FeeInfoGuid)
                    .HasColumnName("FeeInfoGUID")
                    .HasComment("收费项目ID");

                entity.Property(e => e.FeeInfoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("收费项目名称");

                entity.Property(e => e.IsRealFlag).HasComment("是否有效");

                entity.Property(e => e.IsUploadFlag).HasComment("是否上传");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("上传者ID");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(20)
                    .HasComment("上传者姓名");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("单价");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("总价");

                entity.Property(e => e.Unit)
                    .HasMaxLength(5)
                    .HasComment("单位");

                entity.Property(e => e.UploadDate)
                    .HasColumnType("datetime")
                    .HasComment("上传时间");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FeeInfoGu)
                    .WithMany(p => p.StudyFeeItemIndices)
                    .HasForeignKey(d => d.FeeInfoGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyFeeItemIndex_FeeInfo");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.StudyFeeItemIndices)
                    .HasForeignKey(d => d.OwnerGuid)
                    .HasConstraintName("FK_StudyFeeItemIndex_Users");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyFeeItemIndices)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyFeeItemIndex_Study");
            });

            modelBuilder.Entity<StudyImageInfo>(entity =>
            {
                entity.ToTable("StudyImageInfo");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyImageInfo_StudyGUID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.DeviceGuid)
                    .HasColumnName("DeviceGUID")
                    .HasComment("检查设备");

                entity.Property(e => e.ImageCount).HasComment("图像数量");

                entity.Property(e => e.ImageGrade).HasComment("评级等级");

                entity.Property(e => e.ImageGradeDate)
                    .HasColumnType("datetime")
                    .HasComment("评级时间");

                entity.Property(e => e.ImageGradeNote)
                    .HasMaxLength(150)
                    .HasComment("评级原因");

                entity.Property(e => e.ImageGradeOwnerGuid)
                    .HasColumnName("ImageGradeOwnerGUID")
                    .HasComment("评级者");

                entity.Property(e => e.LightCount)
                    .HasColumnType("numeric(10, 4)")
                    .HasComment("备用1");

                entity.Property(e => e.LightExposure)
                    .HasColumnType("numeric(10, 4)")
                    .HasComment("曝光量");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.DeviceGu)
                    .WithMany(p => p.StudyImageInfos)
                    .HasForeignKey(d => d.DeviceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyImageInfo_DeviceInfo");

                entity.HasOne(d => d.ImageGradeOwnerGu)
                    .WithMany(p => p.StudyImageInfos)
                    .HasForeignKey(d => d.ImageGradeOwnerGuid)
                    .HasConstraintName("FK_StudyImageInfo_Users");

                entity.HasOne(d => d.StudyGu)
                    .WithOne(p => p.StudyImageInfo)
                    .HasForeignKey<StudyImageInfo>(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyImageInfo_Study");
            });

            modelBuilder.Entity<StudyItemIndex>(entity =>
            {
                entity.ToTable("StudyItemIndex");

                entity.HasIndex(e => e.ItemTypeGuid, "IX_StudyItemIndex_ItemTypeGUID");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyItemIndex_StudyGUID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasComment("项目GUID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("项目名称");

                entity.Property(e => e.ItemTypeGuid)
                    .HasColumnName("ItemTypeGUID")
                    .HasComment("项目大类GUID");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ItemGu)
                    .WithMany(p => p.StudyItemIndices)
                    .HasForeignKey(d => d.ItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyItemIndex_Item");

                entity.HasOne(d => d.ItemTypeGu)
                    .WithMany(p => p.StudyItemIndices)
                    .HasForeignKey(d => d.ItemTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyItemIndex_ItemType");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyItemIndices)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyItemIndex_Study");
            });

            modelBuilder.Entity<StudyKeyImage>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("StudyKeyImage");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyKeyImage_StudyGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ImageFlag).HasComment("重点标识");

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasComment("图像名称");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("图像路径");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.ServerPath)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("服务器路径");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyKeyImages)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyKeyImage_STUDY");
            });

            modelBuilder.Entity<StudyLock>(entity =>
            {
                entity.ToTable("StudyLock");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyLock_StudyGUID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.LockTime)
                    .HasColumnType("datetime")
                    .HasComment("锁定时间");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("操作者ID");

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("操作者名称");

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.StudyLocks)
                    .HasForeignKey(d => d.OwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyLock_Users");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyLocks)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyLock_Study");
            });

            modelBuilder.Entity<StudyLog>(entity =>
            {
                entity.ToTable("StudyLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.ActorGuid).HasColumnName("ActorGUID");

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.HasOne(d => d.ActorGu)
                    .WithMany(p => p.StudyLogs)
                    .HasForeignKey(d => d.ActorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudyLog__ActorG__55209ACA");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyLogs)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudyLog__StudyG__542C7691");
            });

            modelBuilder.Entity<StudyPrintingLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("StudyPrintingLog");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyPrintingLog_StudyGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComment("打印时间");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("备注");

                entity.Property(e => e.OperatorGuid)
                    .HasColumnName("OperatorGUID")
                    .HasComment("操作者ID");

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasComment("操作者名称");

                entity.Property(e => e.PrintSite)
                    .HasMaxLength(50)
                    .HasComment("打印地点");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("StudyGUID");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyPrintingLogs)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyPrintingLog_Study");
            });

            modelBuilder.Entity<StudyQuestFile>(entity =>
            {
                entity.ToTable("StudyQuestFile");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyQuestFile_StudyGUID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("文件名称");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("扫描文件路径");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComment("扫描时间");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("扫描者ID");

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasComment("扫描者名称");

                entity.Property(e => e.ServerPath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("服务器共享路径");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.StudyQuestFiles)
                    .HasForeignKey(d => d.OwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyQuestFile_Users");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyQuestFiles)
                    .HasForeignKey(d => d.StudyGuid)
                    .HasConstraintName("FK_StudyQuestFile_STUDY");
            });

            modelBuilder.Entity<StudyQueue>(entity =>
            {
                entity.ToTable("StudyQueue");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyQueue_StudyGUID")
                    .IsUnique();

                entity.HasIndex(e => e.StudyRoomGuid, "IX_StudyQueue_StudyRoomGUID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.CallStatus).HasComment("队列状态");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排队序号");

                entity.Property(e => e.Priority).HasComment("优先级");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查号");

                entity.Property(e => e.StudyRoomGuid)
                    .HasColumnName("StudyRoomGUID")
                    .HasComment("检查地点");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.StudyGu)
                    .WithOne(p => p.StudyQueue)
                    .HasForeignKey<StudyQueue>(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyQueue_Study");

                entity.HasOne(d => d.StudyRoomGu)
                    .WithMany(p => p.StudyQueues)
                    .HasForeignKey(d => d.StudyRoomGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyQueue_ExamRoom");
            });

            modelBuilder.Entity<StudySchInfo>(entity =>
            {
                entity.ToTable("StudySchInfo");

                entity.HasIndex(e => e.StudyGuid, "IX_StudySchInfo_StudyGUID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("预约排号");

                entity.Property(e => e.SchDate)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("预约日期");

                entity.Property(e => e.SchItemGuid)
                    .HasColumnName("SchItemGUID")
                    .HasComment("预约项目");

                entity.Property(e => e.SchTimeGuid)
                    .HasColumnName("SchTimeGUID")
                    .HasComment("预约时间");

                entity.Property(e => e.SlotTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.HasOne(d => d.SchTimeGu)
                    .WithMany(p => p.StudySchInfos)
                    .HasForeignKey(d => d.SchTimeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudySchInfo_ArrangeTime");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudySchInfos)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudySchInfo_Study");
            });

            modelBuilder.Entity<StudySchInfoHi>(entity =>
            {
                entity.HasKey(e => e.Sequence);

                entity.Property(e => e.Sequence).ValueGeneratedNever();

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicaitonTime).HasColumnType("datetime");

                entity.Property(e => e.Blkh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BLKH");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.ModeGuid).HasColumnName("ModeGUID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlotTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudySchInfoHisItem>(entity =>
            {
                entity.ToTable("StudySchInfoHisItem");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<StudyStatusChange>(entity =>
            {
                entity.ToTable("StudyStatusChange");

                entity.HasIndex(e => e.InsertDate, "IX_StudyStatusChange_InsertDate");

                entity.HasIndex(e => e.StudyStatus, "IX_StudyStatusChange_StudyStatus");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.EventCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("控制代码");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasComment("产生时间");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RequestID")
                    .HasComment("应答号");

                entity.Property(e => e.SendObject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发送对象");

                entity.Property(e => e.SendStatus).HasComment("发送状态");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.Property(e => e.StudyStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("检查状态");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyStatusChanges)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyStatusChange_Study");
            });

            modelBuilder.Entity<StudyStatusLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("StudyStatusLog");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyStatusLog_StudyGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.OperatorGuid).HasColumnName("OperatorGUID");

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Stage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StudyGuid).HasColumnName("StudyGUID");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.OperatorGu)
                    .WithMany(p => p.StudyStatusLogs)
                    .HasForeignKey(d => d.OperatorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyStatusLog_Users");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyStatusLogs)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyStatusLog_Study");
            });

            modelBuilder.Entity<StudyTemp>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_StudyTemp_GUID")
                    .IsClustered(false);

                entity.ToTable("StudyTemp");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.AccNum)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BedNo)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Bkb).HasColumnName("BKB");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI");

                entity.Property(e => e.Bks1).HasColumnName("BKS1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3");

                entity.Property(e => e.CliniAge)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CliniAgeUnit)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CliniDeptGuid).HasColumnName("CliniDeptGUID");

                entity.Property(e => e.CliniDoctorGuid).HasColumnName("CliniDoctorGUID");

                entity.Property(e => e.CliniItem).HasMaxLength(150);

                entity.Property(e => e.CliniRequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CliniStudyDate).HasColumnType("datetime");

                entity.Property(e => e.DailySequence).HasMaxLength(20);

                entity.Property(e => e.Danger).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstimateCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.FeeTypeGuid).HasColumnName("FeeTypeGUID");

                entity.Property(e => e.ModeGuid).HasColumnName("ModeGUID");

                entity.Property(e => e.ModeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaperPrintFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaperPrintNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");

                entity.Property(e => e.ReferAccnum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RegOperatorGuid).HasColumnName("RegOperatorGUID");

                entity.Property(e => e.RegionGuid).HasColumnName("RegionGUID");

                entity.Property(e => e.StudyDate).HasColumnType("datetime");

                entity.Property(e => e.StudyInitSource)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyItemNames).IsRequired();

                entity.Property(e => e.StudyOperatorGuid).HasColumnName("StudyOperatorGUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Vip).HasDefaultValueSql("((0))");

                entity.Property(e => e.VisitNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTypeGuid).HasColumnName("VisitTypeGUID");

                entity.HasOne(d => d.CliniDeptGu)
                    .WithMany(p => p.StudyTemps)
                    .HasForeignKey(d => d.CliniDeptGuid)
                    .HasConstraintName("FK_StudyTemp_Department");

                entity.HasOne(d => d.CliniDoctorGu)
                    .WithMany(p => p.StudyTemps)
                    .HasForeignKey(d => d.CliniDoctorGuid)
                    .HasConstraintName("FK_StudyTemp_ClinicianInfo");

                entity.HasOne(d => d.FeeTypeGu)
                    .WithMany(p => p.StudyTemps)
                    .HasForeignKey(d => d.FeeTypeGuid)
                    .HasConstraintName("FK_StudyTemp_FeeType");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.StudyTemps)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyTemp_Mode");

                entity.HasOne(d => d.PatientGu)
                    .WithMany(p => p.StudyTemps)
                    .HasForeignKey(d => d.PatientGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyTemp_Patient");

                entity.HasOne(d => d.RegOperatorGu)
                    .WithMany(p => p.StudyTempRegOperatorGus)
                    .HasForeignKey(d => d.RegOperatorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyTemp_Users");

                entity.HasOne(d => d.RegionGu)
                    .WithMany(p => p.StudyTemps)
                    .HasForeignKey(d => d.RegionGuid)
                    .HasConstraintName("FK_StudyTemp_Region");

                entity.HasOne(d => d.StudyOperatorGu)
                    .WithMany(p => p.StudyTempStudyOperatorGus)
                    .HasForeignKey(d => d.StudyOperatorGuid)
                    .HasConstraintName("FK_StudyTemp_Users_StudyOperator");

                entity.HasOne(d => d.VisitTypeGu)
                    .WithMany(p => p.StudyTemps)
                    .HasForeignKey(d => d.VisitTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyTemp_VisitType");
            });

            modelBuilder.Entity<StudyTimeAxis>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("StudyTimeAxis");

                entity.HasIndex(e => e.StudyGuid, "IX_StudyTimeAxis_StudyGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作名称");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasComment("操作时间");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .HasComment("备注");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("操作者");

                entity.Property(e => e.StudyGuid)
                    .HasColumnName("StudyGUID")
                    .HasComment("检查GUID");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.StudyTimeAxes)
                    .HasForeignKey(d => d.OwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyTimeAxis_Users");

                entity.HasOne(d => d.StudyGu)
                    .WithMany(p => p.StudyTimeAxes)
                    .HasForeignKey(d => d.StudyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyTimeAxis_Study");
            });

            modelBuilder.Entity<Style>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("Style");

                entity.HasIndex(e => e.StyleTypeGuid, "IX_Style_StyleTypeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("样式GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasComment("内容");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Footer)
                    .HasDefaultValueSql("('')")
                    .HasComment("注脚");

                entity.Property(e => e.Header)
                    .HasDefaultValueSql("('')")
                    .HasComment("表头");

                entity.Property(e => e.Height).HasComment("高度");

                entity.Property(e => e.IsEmergency)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.PageSizeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A4')");

                entity.Property(e => e.PrintName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("打印机名称");

                entity.Property(e => e.PrintNum).HasComment("打印份数");

                entity.Property(e => e.StyleTypeGuid)
                    .HasColumnName("StyleTypeGUID")
                    .HasComment("样式大类");

                entity.Property(e => e.Width).HasComment("宽度");

                entity.HasOne(d => d.StyleTypeGu)
                    .WithMany(p => p.Styles)
                    .HasForeignKey(d => d.StyleTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Style_StyleType");
            });

            modelBuilder.Entity<StyleModeIndex>(entity =>
            {
                entity.ToTable("StyleModeIndex");

                entity.HasIndex(e => new { e.ModeGuid, e.StyleTypeGuid }, "IX_StyleModeIndex");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式GUID");

                entity.Property(e => e.StyleGuid)
                    .HasColumnName("StyleGUID")
                    .HasComment("样式GUID");

                entity.Property(e => e.StyleTypeGuid)
                    .HasColumnName("StyleTypeGUID")
                    .HasComment("样式大类GUID");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.StyleModeIndices)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StyleModeIndex_Mode");

                entity.HasOne(d => d.StyleGu)
                    .WithMany(p => p.StyleModeIndices)
                    .HasForeignKey(d => d.StyleGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StyleModeIndex_Style");

                entity.HasOne(d => d.StyleTypeGu)
                    .WithMany(p => p.StyleModeIndices)
                    .HasForeignKey(d => d.StyleTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StyleModeIndex_StyleType");
            });

            modelBuilder.Entity<StyleType>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("StyleType");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("样式大类GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("样式名称");
            });

            modelBuilder.Entity<SubAnotomical>(entity =>
            {
                entity.HasKey(e => new { e.Aid, e.Sid })
                    .IsClustered(false);

                entity.ToTable("SubAnotomical");

                entity.HasIndex(e => e.Aid, "IX_SubAnotomical_Aid")
                    .IsClustered();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_EN");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.SubAnotomicals)
                    .HasForeignKey(d => d.Aid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubAnotomical_Anotomical");
            });

            modelBuilder.Entity<SubPathological>(entity =>
            {
                entity.HasKey(e => new { e.Aid, e.Pid, e.Sid })
                    .IsClustered(false);

                entity.ToTable("SubPathological");

                entity.HasIndex(e => new { e.Aid, e.Pid }, "IX_SubPathological")
                    .IsClustered();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DescriptionEn).HasColumnName("Description_EN");

                entity.HasOne(d => d.Pathological)
                    .WithMany(p => p.SubPathologicals)
                    .HasForeignKey(d => new { d.Aid, d.Pid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubPathological_Pathological");
            });

            modelBuilder.Entity<SurDcmWorklistView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SurDcmWorklistView");

                entity.Property(e => e.AccessNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.NamePy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NamePY");

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("pName");

                entity.Property(e => e.PatientBirthDate1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PatientID");

                entity.Property(e => e.RItem)
                    .IsRequired()
                    .HasColumnName("rItem");

                entity.Property(e => e.RMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rMod");

                entity.Property(e => e.RPhisician)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rPhisician");

                entity.Property(e => e.RSymptom).HasColumnName("rSymptom");

                entity.Property(e => e.RType).HasColumnName("rType");

                entity.Property(e => e.SchDate1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SchStudyRoomId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SchStudyRoomID");

                entity.Property(e => e.SchTime1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StuId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("StuID");

                entity.Property(e => e.StuInsuId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("StuInsuID");

                entity.Property(e => e.StuPhy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StuPhyId).HasColumnName("StuPhyID");

                entity.Property(e => e.StudyDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyInitSource)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyTime)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Yxid1)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("YXID1");
            });

            modelBuilder.Entity<SurDcmWorklistViewBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SurDcmWorklistViewBAK");

                entity.Property(e => e.AccessNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.NamePy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NamePY");

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("pName");

                entity.Property(e => e.PatientBirthDate1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PatientID");

                entity.Property(e => e.RItem)
                    .IsRequired()
                    .HasColumnName("rItem");

                entity.Property(e => e.RMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rMod");

                entity.Property(e => e.RPhisician)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rPhisician");

                entity.Property(e => e.RSymptom).HasColumnName("rSymptom");

                entity.Property(e => e.RType).HasColumnName("rType");

                entity.Property(e => e.SchDate1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SchStudyRoomId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SchStudyRoomID");

                entity.Property(e => e.SchTime1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StuId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("StuID");

                entity.Property(e => e.StuInsuId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("StuInsuID");

                entity.Property(e => e.StuPhy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StuPhyId).HasColumnName("StuPhyID");

                entity.Property(e => e.StudyDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyInitSource)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyTime)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Yxid1)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("YXID1");
            });

            modelBuilder.Entity<SurDcmWorklistViewtest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SurDcmWorklistViewtest");

                entity.Property(e => e.AccessNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.NamePy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NamePY");

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("pName");

                entity.Property(e => e.PatientBirthDate1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PatientID");

                entity.Property(e => e.RItem)
                    .IsRequired()
                    .HasColumnName("rItem");

                entity.Property(e => e.RMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rMod");

                entity.Property(e => e.RPhisician)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rPhisician");

                entity.Property(e => e.RSymptom).HasColumnName("rSymptom");

                entity.Property(e => e.RType).HasColumnName("rType");

                entity.Property(e => e.SchDate1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SchStudyRoomId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SchStudyRoomID");

                entity.Property(e => e.SchTime1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StuId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("StuID");

                entity.Property(e => e.StuInsuId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("StuInsuID");

                entity.Property(e => e.StuPhy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StuPhyId).HasColumnName("StuPhyID");

                entity.Property(e => e.StudyDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyInitSource)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyTime)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Yxid1)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("YXID1");
            });

            modelBuilder.Entity<TechPlan>(entity =>
            {
                entity.ToTable("TechPlan");

                entity.Property(e => e.TechPlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("TechPlanID");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.StudyInfoId)
                    .HasMaxLength(500)
                    .HasColumnName("StudyInfoID");

                entity.Property(e => e.TechPlanCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TechPlanName).HasMaxLength(20);

                entity.Property(e => e.Ttype)
                    .HasMaxLength(20)
                    .HasColumnName("TType")
                    .IsFixedLength(true);

                entity.HasOne(d => d.AuthorNavigation)
                    .WithMany(p => p.TechPlans)
                    .HasForeignKey(d => d.Author)
                    .HasConstraintName("FK_TechPlan_Staff");
            });

            modelBuilder.Entity<TechPlanDiscuss>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TechPlanDiscuss");

                entity.Property(e => e.BakeUp2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Dicussant)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussContent)
                    .HasMaxLength(2000)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussContentId)
                    .HasMaxLength(10)
                    .HasColumnName("DiscussContentID")
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussId).HasColumnName("DiscussID");

                entity.Property(e => e.DiscussLevel)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussTime).HasColumnType("datetime");

                entity.Property(e => e.DiscussTitle)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanId).HasColumnName("TechPlanID");
            });

            modelBuilder.Entity<TechPlanFullView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TechPlanFullView");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Dcontent)
                    .HasMaxLength(3000)
                    .HasColumnName("DContent");

                entity.Property(e => e.DescripTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionId)
                    .HasMaxLength(10)
                    .HasColumnName("DescriptionID")
                    .IsFixedLength(true);

                entity.Property(e => e.Dicussant)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussContent)
                    .HasMaxLength(2000)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussContentId)
                    .HasMaxLength(10)
                    .HasColumnName("DiscussContentID")
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussLevel)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussTime).HasColumnType("datetime");

                entity.Property(e => e.DiscussTitle)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.KeyWords)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Sharestatus)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sharestatus");

                entity.Property(e => e.StudyInfoId)
                    .HasMaxLength(50)
                    .HasColumnName("StudyInfoID")
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TechPlanId).HasColumnName("TechPlanID");

                entity.Property(e => e.TechPlanName).HasMaxLength(20);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TechPlanView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TechPlanView");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.CheckItemName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Dcontent)
                    .HasMaxLength(3000)
                    .HasColumnName("DContent");

                entity.Property(e => e.DescripTime).HasColumnType("datetime");

                entity.Property(e => e.KeyWords)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Sharestatus)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sharestatus");

                entity.Property(e => e.StudyInfoId)
                    .HasMaxLength(50)
                    .HasColumnName("StudyInfoID")
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TechPlanId).HasColumnName("TechPlanID");

                entity.Property(e => e.TechPlanName).HasMaxLength(20);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Ttype)
                    .HasMaxLength(20)
                    .HasColumnName("TType")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TechnicalPost>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_TECHNICALPOST")
                    .IsClustered(false);

                entity.ToTable("TechnicalPost");

                entity.HasIndex(e => e.OrderId, "IX_TechnicalPost_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("序号");

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("首拼");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("Template");

                entity.HasIndex(e => e.ItemTypeGuid, "IX_Template_ItemTypeGUID")
                    .IsClustered();

                entity.HasIndex(e => e.ModeTypeGuid, "IX_Template_ModeTypeGUID");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Description).HasComment("描述");

                entity.Property(e => e.Diagnosis).HasComment("诊断");

                entity.Property(e => e.IsPublic).HasComment("是否公共模板");

                entity.Property(e => e.ItemTypeGuid)
                    .HasColumnName("ItemTypeGUID")
                    .HasComment("项目大类GUID");

                entity.Property(e => e.Method).HasComment("方法");

                entity.Property(e => e.ModeTypeGuid).HasColumnName("ModeTypeGUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("模板名称");

                entity.Property(e => e.Note).HasComment("备注");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("所有者");

                entity.Property(e => e.PositiveDesc).HasComment("阳性备注");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PY")
                    .HasComment("拼首");

                entity.Property(e => e.Qualitative).HasComment("阴阳性标识");
            });

            modelBuilder.Entity<TestStudyFromHi>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HisClinicDeptCode).HasMaxLength(100);

                entity.Property(e => e.HisClinicDeptName).HasMaxLength(500);

                entity.Property(e => e.HisClinicDoctorCode).HasMaxLength(100);

                entity.Property(e => e.HisClinicDoctorName).HasMaxLength(500);

                entity.Property(e => e.HisClinicRegionCode).HasMaxLength(100);

                entity.Property(e => e.HisDiagnosis).HasMaxLength(200);

                entity.Property(e => e.HisExamRoomCode).HasMaxLength(100);

                entity.Property(e => e.HisFeeItemAmount).HasMaxLength(100);

                entity.Property(e => e.HisFeeItemCode).HasMaxLength(100);

                entity.Property(e => e.HisFeeItemCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HisFeeItemCostUnit).HasMaxLength(100);

                entity.Property(e => e.HisFeeItemName).HasMaxLength(500);

                entity.Property(e => e.HisFeeTypeCode).HasMaxLength(100);

                entity.Property(e => e.HisHistoryDesc).HasMaxLength(200);

                entity.Property(e => e.HisItemName).HasMaxLength(200);

                entity.Property(e => e.HisKeyWord)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HisModeTypeCode).HasMaxLength(100);

                entity.Property(e => e.HisPatientAddress).HasMaxLength(100);

                entity.Property(e => e.HisPatientAge).HasMaxLength(50);

                entity.Property(e => e.HisPatientAgeUnit).HasMaxLength(50);

                entity.Property(e => e.HisPatientBirthday).HasColumnType("datetime");

                entity.Property(e => e.HisPatientBlkh)
                    .HasMaxLength(100)
                    .HasColumnName("HisPatientBLKH");

                entity.Property(e => e.HisPatientHeight).HasMaxLength(100);

                entity.Property(e => e.HisPatientHeightUnit).HasMaxLength(100);

                entity.Property(e => e.HisPatientId)
                    .HasMaxLength(500)
                    .HasColumnName("HisPatientID");

                entity.Property(e => e.HisPatientIdcard)
                    .HasMaxLength(100)
                    .HasColumnName("HisPatientIDCard");

                entity.Property(e => e.HisPatientName).HasMaxLength(50);

                entity.Property(e => e.HisPatientPhone).HasMaxLength(100);

                entity.Property(e => e.HisPatientPostCode).HasMaxLength(100);

                entity.Property(e => e.HisPatientPy)
                    .HasMaxLength(500)
                    .HasColumnName("HisPatientPY");

                entity.Property(e => e.HisPatientSex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HisPatientWeight).HasMaxLength(100);

                entity.Property(e => e.HisPatientWeightUnit).HasMaxLength(100);

                entity.Property(e => e.HisPatientYbkh)
                    .HasMaxLength(100)
                    .HasColumnName("HisPatientYBKH");

                entity.Property(e => e.HisStudyDate).HasColumnType("datetime");

                entity.Property(e => e.HisStudyItemCode).HasMaxLength(100);

                entity.Property(e => e.HisSymptom).HasMaxLength(200);

                entity.Property(e => e.HisTotalFee).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HisVisitNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HisVisitTypeCode).HasMaxLength(100);
            });

            modelBuilder.Entity<Tpdescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TPDescription");

                entity.Property(e => e.Dcontent)
                    .HasMaxLength(3000)
                    .HasColumnName("DContent");

                entity.Property(e => e.DescripTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionId)
                    .HasMaxLength(10)
                    .HasColumnName("DescriptionID")
                    .IsFixedLength(true);

                entity.Property(e => e.KeyWords)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanId).HasColumnName("TechPlanID");

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<Tpdiscuss>(entity =>
            {
                entity.HasKey(e => e.DiscussId);

                entity.ToTable("TPDiscuss");

                entity.Property(e => e.DiscussId)
                    .ValueGeneratedNever()
                    .HasColumnName("DiscussID");

                entity.Property(e => e.Dicussant)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussLevel)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussTime).HasColumnType("datetime");

                entity.Property(e => e.TechPlanId).HasColumnName("TechPlanID");
            });

            modelBuilder.Entity<TpdiscussContent>(entity =>
            {
                entity.HasKey(e => e.DiscussId);

                entity.ToTable("TPDiscussContent");

                entity.Property(e => e.DiscussId)
                    .ValueGeneratedNever()
                    .HasColumnName("DiscussID");

                entity.Property(e => e.BakeUp2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BakeUp3)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BakeUp4)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussContent)
                    .HasMaxLength(2000)
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussContentId)
                    .HasMaxLength(10)
                    .HasColumnName("DiscussContentID")
                    .IsFixedLength(true);

                entity.Property(e => e.DiscussTitle)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.HasIndex(e => e.OrderId, "IX_Users_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasComment("家庭地址");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasComment("出身日期");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.DefaultStation)
                    .HasMaxLength(50)
                    .HasColumnName("defaultStation");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasComment("邮件");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.Gh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GH")
                    .HasComment("工号");

                entity.Property(e => e.IsInner).HasComment("是否本院");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasComment("姓名");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("序号");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasComment("登陆密码");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasComment("电话");

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .HasComment("照片");

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("拼首");

                entity.Property(e => e.RoleGuid)
                    .HasColumnName("RoleGUID")
                    .HasComment("职称GUID");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .HasComment("性别");

                entity.Property(e => e.TechnicalGuid)
                    .HasColumnName("TechnicalGUID")
                    .HasComment("岗位GUID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("登陆名");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.RoleGu)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleGuid)
                    .HasConstraintName("FK_Users_RolePost");

                entity.HasOne(d => d.TechnicalGu)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TechnicalGuid)
                    .HasConstraintName("FK_Users_TechnicalPost");
            });

            modelBuilder.Entity<UserCustomedSetting>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.UserGuid, "IX_UserCustomedSettings_UserGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.UserDefaultSettingsGuid)
                    .HasColumnName("UserDefaultSettingsGUID")
                    .HasComment("默认配置GUID");

                entity.Property(e => e.UserGuid)
                    .HasColumnName("UserGUID")
                    .HasComment("用户GUID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasComment("内容");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.UserDefaultSettingsGu)
                    .WithMany(p => p.UserCustomedSettings)
                    .HasForeignKey(d => d.UserDefaultSettingsGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCustomedSettings_UserDefaultSettings");

                entity.HasOne(d => d.UserGu)
                    .WithMany(p => p.UserCustomedSettings)
                    .HasForeignKey(d => d.UserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCustomedSettings_Users");
            });

            modelBuilder.Entity<UserDefaultSetting>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.HasIndex(e => e.AccessFunctionTypeGuid, "IX_UserDefaultSettings_AccessFunctionTypeGUID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID")
                    .HasComment("配置GUID");

                entity.Property(e => e.AccessFunctionTypeGuid)
                    .HasColumnName("AccessFunctionTypeGUID")
                    .HasComment("所属大类GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("键值");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("备注");

                entity.Property(e => e.Options)
                    .HasMaxLength(250)
                    .HasComment("选项");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("标题");

                entity.Property(e => e.Type).HasComment("类型");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasComment("内容");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AccessFunctionTypeGu)
                    .WithMany(p => p.UserDefaultSettings)
                    .HasForeignKey(d => d.AccessFunctionTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDefaultSettings_AccessFunctionType");
            });

            modelBuilder.Entity<UserInterMessage>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("UserInterMessage");

                entity.HasIndex(e => e.InterMessageGuid, "IX_UserInterMessage_InterMessageGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.InterMessageGuid)
                    .HasColumnName("InterMessageGUID")
                    .HasComment("消息GUID");

                entity.Property(e => e.IsRead).HasComment("是否已读");

                entity.Property(e => e.IsRemoved).HasComment("是否删除");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnName("OwnerGUID")
                    .HasComment("所有者");

                entity.HasOne(d => d.InterMessageGu)
                    .WithMany(p => p.UserInterMessages)
                    .HasForeignKey(d => d.InterMessageGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInterMessage_InterMessage");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.UserInterMessages)
                    .HasForeignKey(d => d.OwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInterMessage_Users");
            });

            modelBuilder.Entity<UserKeyword>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__UserKeyw__15B69B8E5EDF0F2E");

                entity.ToTable("UserKeyword");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Keyword).HasMaxLength(1000);
            });

            modelBuilder.Entity<UserModeIndex>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("UserModeIndex");

                entity.HasIndex(e => e.UsersGuid, "IX_UserModeIndex_UsersGUID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("序号");

                entity.Property(e => e.ModeGuid)
                    .HasColumnName("ModeGUID")
                    .HasComment("模式GUID");

                entity.Property(e => e.UsersGuid)
                    .HasColumnName("UsersGUID")
                    .HasComment("用户GUID");

                entity.HasOne(d => d.ModeGu)
                    .WithMany(p => p.UserModeIndices)
                    .HasForeignKey(d => d.ModeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModeIndex_Mode");

                entity.HasOne(d => d.UsersGu)
                    .WithMany(p => p.UserModeIndices)
                    .HasForeignKey(d => d.UsersGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModeIndex_Users");
            });

            modelBuilder.Entity<UserQueryCondition>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.OwnerGuid).HasColumnName("OwnerGUID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkstationCode)
                    .HasMaxLength(20)
                    .HasComment("备用1");

                entity.HasOne(d => d.OwnerGu)
                    .WithMany(p => p.UserQueryConditions)
                    .HasForeignKey(d => d.OwnerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserQueryConditions_Users");
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("UserToken");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.ExpiredTime)
                    .HasColumnType("datetime")
                    .HasComment("失效时间");

                entity.Property(e => e.GenerateTime)
                    .HasColumnType("datetime")
                    .HasComment("产生时间");

                entity.Property(e => e.Token).HasComment("密钥");

                entity.Property(e => e.UserGuid)
                    .HasColumnName("UserGUID")
                    .HasComment("用户GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UsersAccess>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("UsersAccess");

                entity.HasIndex(e => e.UsersGuid, "IX_UsersAccess_UsersGUID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessFunctionGuid)
                    .HasColumnName("AccessFunctionGUID")
                    .HasComment("功能GUID");

                entity.Property(e => e.UsersGuid)
                    .HasColumnName("UsersGUID")
                    .HasComment("用户GUID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.UsersGu)
                    .WithMany(p => p.UsersAccesses)
                    .HasForeignKey(d => d.UsersGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAccess_Users");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Dcontent)
                    .HasMaxLength(3000)
                    .HasColumnName("DContent");

                entity.Property(e => e.DescripTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionId)
                    .HasMaxLength(10)
                    .HasColumnName("DescriptionID")
                    .IsFixedLength(true);

                entity.Property(e => e.KeyWords)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StudyInfoId)
                    .HasMaxLength(50)
                    .HasColumnName("StudyInfoID")
                    .IsFixedLength(true);

                entity.Property(e => e.TechPlanCreateTime).HasColumnType("datetime");

                entity.Property(e => e.TechPlanId).HasColumnName("TechPlanID");

                entity.Property(e => e.TechPlanName).HasMaxLength(20);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ViewGetStudyInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GetStudyInfo");

                entity.Property(e => e.AccNum)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Birdat)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRDAT");

                entity.Property(e => e.ItemNames).IsRequired();

                entity.Property(e => e.Patientid)
                    .HasMaxLength(200)
                    .HasColumnName("PATIENTID");

                entity.Property(e => e.ReportUrl)
                    .IsRequired()
                    .HasMaxLength(236);

                entity.Property(e => e.Repphy).HasMaxLength(12);

                entity.Property(e => e.Ritem)
                    .IsRequired()
                    .HasColumnName("RITEM");

                entity.Property(e => e.Rmod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RMOD");

                entity.Property(e => e.Sextitle)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SEXTITLE");

                entity.Property(e => e.Studate)
                    .HasColumnType("datetime")
                    .HasColumnName("STUDATE");

                entity.Property(e => e.StudyId).HasColumnName("StudyID");

                entity.Property(e => e.Stuid)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("STUID");
            });

            modelBuilder.Entity<VisitType>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .IsClustered(false);

                entity.ToTable("VisitType");

                entity.HasIndex(e => e.OrderId, "IX_VisitType_OrderID")
                    .IsClustered();

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Bkb)
                    .HasColumnName("BKB")
                    .HasComment("备用6");

                entity.Property(e => e.Bkd)
                    .HasColumnType("datetime")
                    .HasColumnName("BKD")
                    .HasComment("备用4");

                entity.Property(e => e.Bki)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("BKI")
                    .HasComment("备用5");

                entity.Property(e => e.Bks1)
                    .HasMaxLength(50)
                    .HasColumnName("BKS1")
                    .HasComment("备用1");

                entity.Property(e => e.Bks2)
                    .HasMaxLength(100)
                    .HasColumnName("BKS2")
                    .HasComment("备用2");

                entity.Property(e => e.Bks3)
                    .HasMaxLength(150)
                    .HasColumnName("BKS3")
                    .HasComment("备用3");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("代码");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .HasComment("说明");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.IsEmergency)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("就诊类型名称");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("排序号");

                entity.Property(e => e.Priority).HasComment("优先级");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasComment("首拼");
            });

            modelBuilder.Entity<VwStudyItemIndex>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStudyItemIndex");

                entity.Property(e => e.ItemProtocolCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudyId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workstation>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("Workstation");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.Cpu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("CPU串号");

                entity.Property(e => e.Enabled).HasComment("是否可用");

                entity.Property(e => e.ExamRoomGuid)
                    .HasColumnName("ExamRoomGUID")
                    .HasComment("检查地点GUID");

                entity.Property(e => e.HardDisk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("硬盘串号");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("主机名称");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .HasComment("IP地址");

                entity.Property(e => e.MacAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("MAC地址");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("昵称");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("刷新时间");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WebServiceUrl)
                    .HasMaxLength(200)
                    .HasColumnName("WebServiceURL")
                    .HasComment("WebService地址");

                entity.HasOne(d => d.ExamRoomGu)
                    .WithMany(p => p.Workstations)
                    .HasForeignKey(d => d.ExamRoomGuid)
                    .HasConstraintName("FK_Workstation_ExamRoom");
            });

            modelBuilder.Entity<YdPac>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("YD_PACS");

                entity.Property(e => e.建议).IsRequired();

                entity.Property(e => e.影像号)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.影像所见).IsRequired();

                entity.Property(e => e.报告医生)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.检查日期)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.检查项目).IsRequired();
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .IsClustered(false);

                entity.ToTable("Staff");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(10)
                    .HasColumnName("StaffID")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AutoID");

                entity.Property(e => e.BelongClass).HasMaxLength(50);

                entity.Property(e => e.BelongPost)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.PassWord).HasMaxLength(20);

                entity.Property(e => e.Permission)
                    .HasMaxLength(12)
                    .IsFixedLength(true);

                entity.Property(e => e.ShiftNums).HasMaxLength(50);

                entity.Property(e => e.ShiftRule).HasMaxLength(200);

                entity.Property(e => e.Skill).HasMaxLength(50);

                entity.Property(e => e.UserGuid).HasDefaultValueSql("(newid())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
