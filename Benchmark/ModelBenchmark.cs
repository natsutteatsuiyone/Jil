namespace Benchmark
{
    using Benchmark.Serializers;
    using Benchmark.Fixture;
    using BenchmarkDotNet.Attributes;

    [Config(typeof(MyConfig))]
    public abstract class ModelBenchmarkBase<TJilSerializer, TUtf8JsonSerializer>
        where TJilSerializer : SerializerBase
        where TUtf8JsonSerializer : SerializerBase
    {
        protected virtual TJilSerializer JilSerializer { get; }

        protected virtual TUtf8JsonSerializer Utf8JsonSerializer { get; }


        protected static readonly ExpressionTreeFixture ExpressionTreeFixture = new ExpressionTreeFixture();



        protected static readonly Benchmark.Models.AccessToken AccessTokenInput = ExpressionTreeFixture.Create<Benchmark.Models.AccessToken>();

        protected static readonly Benchmark.Models.AccountMerge AccountMergeInput = ExpressionTreeFixture.Create<Benchmark.Models.AccountMerge>();

        protected static readonly Benchmark.Models.Answer AnswerInput = ExpressionTreeFixture.Create<Benchmark.Models.Answer>();

        protected static readonly Benchmark.Models.Badge BadgeInput = ExpressionTreeFixture.Create<Benchmark.Models.Badge>();

        protected static readonly Benchmark.Models.Comment CommentInput = ExpressionTreeFixture.Create<Benchmark.Models.Comment>();

        protected static readonly Benchmark.Models.Error ErrorInput = ExpressionTreeFixture.Create<Benchmark.Models.Error>();

        protected static readonly Benchmark.Models.Event EventInput = ExpressionTreeFixture.Create<Benchmark.Models.Event>();

        protected static readonly Benchmark.Models.MobileFeed MobileFeedInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileFeed>();

        protected static readonly Benchmark.Models.MobileQuestion MobileQuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileQuestion>();

        protected static readonly Benchmark.Models.MobileRepChange MobileRepChangeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileRepChange>();

        protected static readonly Benchmark.Models.MobileInboxItem MobileInboxItemInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileInboxItem>();

        protected static readonly Benchmark.Models.MobileBadgeAward MobileBadgeAwardInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBadgeAward>();

        protected static readonly Benchmark.Models.MobilePrivilege MobilePrivilegeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobilePrivilege>();

        protected static readonly Benchmark.Models.MobileCommunityBulletin MobileCommunityBulletinInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileCommunityBulletin>();

        protected static readonly Benchmark.Models.MobileAssociationBonus MobileAssociationBonusInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileAssociationBonus>();

        protected static readonly Benchmark.Models.MobileCareersJobAd MobileCareersJobAdInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileCareersJobAd>();

        protected static readonly Benchmark.Models.MobileBannerAd MobileBannerAdInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBannerAd>();

        protected static readonly Benchmark.Models.MobileUpdateNotice MobileUpdateNoticeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileUpdateNotice>();

        protected static readonly Benchmark.Models.FlagOption FlagOptionInput = ExpressionTreeFixture.Create<Benchmark.Models.FlagOption>();

        protected static readonly Benchmark.Models.InboxItem InboxItemInput = ExpressionTreeFixture.Create<Benchmark.Models.InboxItem>();

        protected static readonly Benchmark.Models.Info InfoInput = ExpressionTreeFixture.Create<Benchmark.Models.Info>();

        protected static readonly Benchmark.Models.NetworkUser NetworkUserInput = ExpressionTreeFixture.Create<Benchmark.Models.NetworkUser>();

        protected static readonly Benchmark.Models.Notification NotificationInput = ExpressionTreeFixture.Create<Benchmark.Models.Notification>();

        protected static readonly Benchmark.Models.Post PostInput = ExpressionTreeFixture.Create<Benchmark.Models.Post>();

        protected static readonly Benchmark.Models.Privilege PrivilegeInput = ExpressionTreeFixture.Create<Benchmark.Models.Privilege>();

        protected static readonly Benchmark.Models.Question QuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.Question>();

        protected static readonly Benchmark.Models.QuestionTimeline QuestionTimelineInput = ExpressionTreeFixture.Create<Benchmark.Models.QuestionTimeline>();

        protected static readonly Benchmark.Models.Reputation ReputationInput = ExpressionTreeFixture.Create<Benchmark.Models.Reputation>();

        protected static readonly Benchmark.Models.ReputationHistory ReputationHistoryInput = ExpressionTreeFixture.Create<Benchmark.Models.ReputationHistory>();

        protected static readonly Benchmark.Models.Revision RevisionInput = ExpressionTreeFixture.Create<Benchmark.Models.Revision>();

        protected static readonly Benchmark.Models.SearchExcerpt SearchExcerptInput = ExpressionTreeFixture.Create<Benchmark.Models.SearchExcerpt>();

        protected static readonly Benchmark.Models.ShallowUser ShallowUserInput = ExpressionTreeFixture.Create<Benchmark.Models.ShallowUser>();

        protected static readonly Benchmark.Models.SuggestedEdit SuggestedEditInput = ExpressionTreeFixture.Create<Benchmark.Models.SuggestedEdit>();

        protected static readonly Benchmark.Models.Tag TagInput = ExpressionTreeFixture.Create<Benchmark.Models.Tag>();

        protected static readonly Benchmark.Models.TagScore TagScoreInput = ExpressionTreeFixture.Create<Benchmark.Models.TagScore>();

        protected static readonly Benchmark.Models.TagSynonym TagSynonymInput = ExpressionTreeFixture.Create<Benchmark.Models.TagSynonym>();

        protected static readonly Benchmark.Models.TagWiki TagWikiInput = ExpressionTreeFixture.Create<Benchmark.Models.TagWiki>();

        protected static readonly Benchmark.Models.TopTag TopTagInput = ExpressionTreeFixture.Create<Benchmark.Models.TopTag>();

        protected static readonly Benchmark.Models.User UserInput = ExpressionTreeFixture.Create<Benchmark.Models.User>();

        protected static readonly Benchmark.Models.UserTimeline UserTimelineInput = ExpressionTreeFixture.Create<Benchmark.Models.UserTimeline>();

        protected static readonly Benchmark.Models.WritePermission WritePermissionInput = ExpressionTreeFixture.Create<Benchmark.Models.WritePermission>();

        protected static readonly Benchmark.Models.MobileBannerAd.MobileBannerAdImage MobileBannerAdImageInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>();

        protected static readonly Benchmark.Models.Info.Site SiteInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.Site>();

        protected static readonly Benchmark.Models.Info.RelatedSite RelatedSiteInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.RelatedSite>();

        protected static readonly Benchmark.Models.Question.ClosedDetails ClosedDetailsInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.ClosedDetails>();

        protected static readonly Benchmark.Models.Question.Notice NoticeInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.Notice>();

        protected static readonly Benchmark.Models.Question.MigrationInfo MigrationInfoInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.MigrationInfo>();

        protected static readonly Benchmark.Models.User.BadgeCount BadgeCountInput = ExpressionTreeFixture.Create<Benchmark.Models.User.BadgeCount>();

        protected static readonly Benchmark.Models.Info.Site.Styling StylingInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.Site.Styling>();

        protected static readonly Benchmark.Models.Question.ClosedDetails.OriginalQuestion OriginalQuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>();


        readonly object AccessTokenOutputOfJilSerializer;
        readonly object AccountMergeOutputOfJilSerializer;
        readonly object AnswerOutputOfJilSerializer;
        readonly object BadgeOutputOfJilSerializer;
        readonly object CommentOutputOfJilSerializer;
        readonly object ErrorOutputOfJilSerializer;
        readonly object EventOutputOfJilSerializer;
        readonly object MobileFeedOutputOfJilSerializer;
        readonly object MobileQuestionOutputOfJilSerializer;
        readonly object MobileRepChangeOutputOfJilSerializer;
        readonly object MobileInboxItemOutputOfJilSerializer;
        readonly object MobileBadgeAwardOutputOfJilSerializer;
        readonly object MobilePrivilegeOutputOfJilSerializer;
        readonly object MobileCommunityBulletinOutputOfJilSerializer;
        readonly object MobileAssociationBonusOutputOfJilSerializer;
        readonly object MobileCareersJobAdOutputOfJilSerializer;
        readonly object MobileBannerAdOutputOfJilSerializer;
        readonly object MobileUpdateNoticeOutputOfJilSerializer;
        readonly object FlagOptionOutputOfJilSerializer;
        readonly object InboxItemOutputOfJilSerializer;
        readonly object InfoOutputOfJilSerializer;
        readonly object NetworkUserOutputOfJilSerializer;
        readonly object NotificationOutputOfJilSerializer;
        readonly object PostOutputOfJilSerializer;
        readonly object PrivilegeOutputOfJilSerializer;
        readonly object QuestionOutputOfJilSerializer;
        readonly object QuestionTimelineOutputOfJilSerializer;
        readonly object ReputationOutputOfJilSerializer;
        readonly object ReputationHistoryOutputOfJilSerializer;
        readonly object RevisionOutputOfJilSerializer;
        readonly object SearchExcerptOutputOfJilSerializer;
        readonly object ShallowUserOutputOfJilSerializer;
        readonly object SuggestedEditOutputOfJilSerializer;
        readonly object TagOutputOfJilSerializer;
        readonly object TagScoreOutputOfJilSerializer;
        readonly object TagSynonymOutputOfJilSerializer;
        readonly object TagWikiOutputOfJilSerializer;
        readonly object TopTagOutputOfJilSerializer;
        readonly object UserOutputOfJilSerializer;
        readonly object UserTimelineOutputOfJilSerializer;
        readonly object WritePermissionOutputOfJilSerializer;
        readonly object MobileBannerAdImageOutputOfJilSerializer;
        readonly object SiteOutputOfJilSerializer;
        readonly object RelatedSiteOutputOfJilSerializer;
        readonly object ClosedDetailsOutputOfJilSerializer;
        readonly object NoticeOutputOfJilSerializer;
        readonly object MigrationInfoOutputOfJilSerializer;
        readonly object BadgeCountOutputOfJilSerializer;
        readonly object StylingOutputOfJilSerializer;
        readonly object OriginalQuestionOutputOfJilSerializer;
        readonly object AccessTokenOutputOfUtf8JsonSerializer;
        readonly object AccountMergeOutputOfUtf8JsonSerializer;
        readonly object AnswerOutputOfUtf8JsonSerializer;
        readonly object BadgeOutputOfUtf8JsonSerializer;
        readonly object CommentOutputOfUtf8JsonSerializer;
        readonly object ErrorOutputOfUtf8JsonSerializer;
        readonly object EventOutputOfUtf8JsonSerializer;
        readonly object MobileFeedOutputOfUtf8JsonSerializer;
        readonly object MobileQuestionOutputOfUtf8JsonSerializer;
        readonly object MobileRepChangeOutputOfUtf8JsonSerializer;
        readonly object MobileInboxItemOutputOfUtf8JsonSerializer;
        readonly object MobileBadgeAwardOutputOfUtf8JsonSerializer;
        readonly object MobilePrivilegeOutputOfUtf8JsonSerializer;
        readonly object MobileCommunityBulletinOutputOfUtf8JsonSerializer;
        readonly object MobileAssociationBonusOutputOfUtf8JsonSerializer;
        readonly object MobileCareersJobAdOutputOfUtf8JsonSerializer;
        readonly object MobileBannerAdOutputOfUtf8JsonSerializer;
        readonly object MobileUpdateNoticeOutputOfUtf8JsonSerializer;
        readonly object FlagOptionOutputOfUtf8JsonSerializer;
        readonly object InboxItemOutputOfUtf8JsonSerializer;
        readonly object InfoOutputOfUtf8JsonSerializer;
        readonly object NetworkUserOutputOfUtf8JsonSerializer;
        readonly object NotificationOutputOfUtf8JsonSerializer;
        readonly object PostOutputOfUtf8JsonSerializer;
        readonly object PrivilegeOutputOfUtf8JsonSerializer;
        readonly object QuestionOutputOfUtf8JsonSerializer;
        readonly object QuestionTimelineOutputOfUtf8JsonSerializer;
        readonly object ReputationOutputOfUtf8JsonSerializer;
        readonly object ReputationHistoryOutputOfUtf8JsonSerializer;
        readonly object RevisionOutputOfUtf8JsonSerializer;
        readonly object SearchExcerptOutputOfUtf8JsonSerializer;
        readonly object ShallowUserOutputOfUtf8JsonSerializer;
        readonly object SuggestedEditOutputOfUtf8JsonSerializer;
        readonly object TagOutputOfUtf8JsonSerializer;
        readonly object TagScoreOutputOfUtf8JsonSerializer;
        readonly object TagSynonymOutputOfUtf8JsonSerializer;
        readonly object TagWikiOutputOfUtf8JsonSerializer;
        readonly object TopTagOutputOfUtf8JsonSerializer;
        readonly object UserOutputOfUtf8JsonSerializer;
        readonly object UserTimelineOutputOfUtf8JsonSerializer;
        readonly object WritePermissionOutputOfUtf8JsonSerializer;
        readonly object MobileBannerAdImageOutputOfUtf8JsonSerializer;
        readonly object SiteOutputOfUtf8JsonSerializer;
        readonly object RelatedSiteOutputOfUtf8JsonSerializer;
        readonly object ClosedDetailsOutputOfUtf8JsonSerializer;
        readonly object NoticeOutputOfUtf8JsonSerializer;
        readonly object MigrationInfoOutputOfUtf8JsonSerializer;
        readonly object BadgeCountOutputOfUtf8JsonSerializer;
        readonly object StylingOutputOfUtf8JsonSerializer;
        readonly object OriginalQuestionOutputOfUtf8JsonSerializer;


        public ModelBenchmarkBase()
        {
            AccessTokenOutputOfJilSerializer = JilSerializer.Serialize(AccessTokenInput);
            AccountMergeOutputOfJilSerializer = JilSerializer.Serialize(AccountMergeInput);
            AnswerOutputOfJilSerializer = JilSerializer.Serialize(AnswerInput);
            BadgeOutputOfJilSerializer = JilSerializer.Serialize(BadgeInput);
            CommentOutputOfJilSerializer = JilSerializer.Serialize(CommentInput);
            ErrorOutputOfJilSerializer = JilSerializer.Serialize(ErrorInput);
            EventOutputOfJilSerializer = JilSerializer.Serialize(EventInput);
            MobileFeedOutputOfJilSerializer = JilSerializer.Serialize(MobileFeedInput);
            MobileQuestionOutputOfJilSerializer = JilSerializer.Serialize(MobileQuestionInput);
            MobileRepChangeOutputOfJilSerializer = JilSerializer.Serialize(MobileRepChangeInput);
            MobileInboxItemOutputOfJilSerializer = JilSerializer.Serialize(MobileInboxItemInput);
            MobileBadgeAwardOutputOfJilSerializer = JilSerializer.Serialize(MobileBadgeAwardInput);
            MobilePrivilegeOutputOfJilSerializer = JilSerializer.Serialize(MobilePrivilegeInput);
            MobileCommunityBulletinOutputOfJilSerializer = JilSerializer.Serialize(MobileCommunityBulletinInput);
            MobileAssociationBonusOutputOfJilSerializer = JilSerializer.Serialize(MobileAssociationBonusInput);
            MobileCareersJobAdOutputOfJilSerializer = JilSerializer.Serialize(MobileCareersJobAdInput);
            MobileBannerAdOutputOfJilSerializer = JilSerializer.Serialize(MobileBannerAdInput);
            MobileUpdateNoticeOutputOfJilSerializer = JilSerializer.Serialize(MobileUpdateNoticeInput);
            FlagOptionOutputOfJilSerializer = JilSerializer.Serialize(FlagOptionInput);
            InboxItemOutputOfJilSerializer = JilSerializer.Serialize(InboxItemInput);
            InfoOutputOfJilSerializer = JilSerializer.Serialize(InfoInput);
            NetworkUserOutputOfJilSerializer = JilSerializer.Serialize(NetworkUserInput);
            NotificationOutputOfJilSerializer = JilSerializer.Serialize(NotificationInput);
            PostOutputOfJilSerializer = JilSerializer.Serialize(PostInput);
            PrivilegeOutputOfJilSerializer = JilSerializer.Serialize(PrivilegeInput);
            QuestionOutputOfJilSerializer = JilSerializer.Serialize(QuestionInput);
            QuestionTimelineOutputOfJilSerializer = JilSerializer.Serialize(QuestionTimelineInput);
            ReputationOutputOfJilSerializer = JilSerializer.Serialize(ReputationInput);
            ReputationHistoryOutputOfJilSerializer = JilSerializer.Serialize(ReputationHistoryInput);
            RevisionOutputOfJilSerializer = JilSerializer.Serialize(RevisionInput);
            SearchExcerptOutputOfJilSerializer = JilSerializer.Serialize(SearchExcerptInput);
            ShallowUserOutputOfJilSerializer = JilSerializer.Serialize(ShallowUserInput);
            SuggestedEditOutputOfJilSerializer = JilSerializer.Serialize(SuggestedEditInput);
            TagOutputOfJilSerializer = JilSerializer.Serialize(TagInput);
            TagScoreOutputOfJilSerializer = JilSerializer.Serialize(TagScoreInput);
            TagSynonymOutputOfJilSerializer = JilSerializer.Serialize(TagSynonymInput);
            TagWikiOutputOfJilSerializer = JilSerializer.Serialize(TagWikiInput);
            TopTagOutputOfJilSerializer = JilSerializer.Serialize(TopTagInput);
            UserOutputOfJilSerializer = JilSerializer.Serialize(UserInput);
            UserTimelineOutputOfJilSerializer = JilSerializer.Serialize(UserTimelineInput);
            WritePermissionOutputOfJilSerializer = JilSerializer.Serialize(WritePermissionInput);
            MobileBannerAdImageOutputOfJilSerializer = JilSerializer.Serialize(MobileBannerAdImageInput);
            SiteOutputOfJilSerializer = JilSerializer.Serialize(SiteInput);
            RelatedSiteOutputOfJilSerializer = JilSerializer.Serialize(RelatedSiteInput);
            ClosedDetailsOutputOfJilSerializer = JilSerializer.Serialize(ClosedDetailsInput);
            NoticeOutputOfJilSerializer = JilSerializer.Serialize(NoticeInput);
            MigrationInfoOutputOfJilSerializer = JilSerializer.Serialize(MigrationInfoInput);
            BadgeCountOutputOfJilSerializer = JilSerializer.Serialize(BadgeCountInput);
            StylingOutputOfJilSerializer = JilSerializer.Serialize(StylingInput);
            OriginalQuestionOutputOfJilSerializer = JilSerializer.Serialize(OriginalQuestionInput);
            AccessTokenOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AccessTokenInput);
            AccountMergeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AccountMergeInput);
            AnswerOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AnswerInput);
            BadgeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(BadgeInput);
            CommentOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(CommentInput);
            ErrorOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ErrorInput);
            EventOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(EventInput);
            MobileFeedOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileFeedInput);
            MobileQuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileQuestionInput);
            MobileRepChangeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileRepChangeInput);
            MobileInboxItemOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileInboxItemInput);
            MobileBadgeAwardOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBadgeAwardInput);
            MobilePrivilegeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobilePrivilegeInput);
            MobileCommunityBulletinOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileCommunityBulletinInput);
            MobileAssociationBonusOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileAssociationBonusInput);
            MobileCareersJobAdOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileCareersJobAdInput);
            MobileBannerAdOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBannerAdInput);
            MobileUpdateNoticeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileUpdateNoticeInput);
            FlagOptionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(FlagOptionInput);
            InboxItemOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(InboxItemInput);
            InfoOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(InfoInput);
            NetworkUserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NetworkUserInput);
            NotificationOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NotificationInput);
            PostOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(PostInput);
            PrivilegeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(PrivilegeInput);
            QuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(QuestionInput);
            QuestionTimelineOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(QuestionTimelineInput);
            ReputationOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ReputationInput);
            ReputationHistoryOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ReputationHistoryInput);
            RevisionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(RevisionInput);
            SearchExcerptOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SearchExcerptInput);
            ShallowUserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ShallowUserInput);
            SuggestedEditOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SuggestedEditInput);
            TagOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagInput);
            TagScoreOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagScoreInput);
            TagSynonymOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagSynonymInput);
            TagWikiOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagWikiInput);
            TopTagOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TopTagInput);
            UserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UserInput);
            UserTimelineOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UserTimelineInput);
            WritePermissionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(WritePermissionInput);
            MobileBannerAdImageOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBannerAdImageInput);
            SiteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SiteInput);
            RelatedSiteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(RelatedSiteInput);
            ClosedDetailsOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ClosedDetailsInput);
            NoticeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NoticeInput);
            MigrationInfoOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MigrationInfoInput);
            BadgeCountOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(BadgeCountInput);
            StylingOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(StylingInput);
            OriginalQuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(OriginalQuestionInput);
        }


        [Benchmark]
        public object SerializeAccessTokenWithJilSerializer()
        {
            return JilSerializer.Serialize(AccessTokenInput);
        }

        [Benchmark]
        public object SerializeAccessTokenWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(AccessTokenInput);
        }

        [Benchmark]
        public object DeserializeAccessTokenWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.AccessToken>(AccessTokenOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeAccessTokenWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.AccessToken>(AccessTokenOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeAccountMergeWithJilSerializer()
        {
            return JilSerializer.Serialize(AccountMergeInput);
        }

        [Benchmark]
        public object SerializeAccountMergeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(AccountMergeInput);
        }

        [Benchmark]
        public object DeserializeAccountMergeWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.AccountMerge>(AccountMergeOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeAccountMergeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.AccountMerge>(AccountMergeOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeAnswerWithJilSerializer()
        {
            return JilSerializer.Serialize(AnswerInput);
        }

        [Benchmark]
        public object SerializeAnswerWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(AnswerInput);
        }

        [Benchmark]
        public object DeserializeAnswerWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Answer>(AnswerOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeAnswerWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Answer>(AnswerOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeBadgeWithJilSerializer()
        {
            return JilSerializer.Serialize(BadgeInput);
        }

        [Benchmark]
        public object SerializeBadgeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(BadgeInput);
        }

        [Benchmark]
        public object DeserializeBadgeWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Badge>(BadgeOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeBadgeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Badge>(BadgeOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeCommentWithJilSerializer()
        {
            return JilSerializer.Serialize(CommentInput);
        }

        [Benchmark]
        public object SerializeCommentWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(CommentInput);
        }

        [Benchmark]
        public object DeserializeCommentWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Comment>(CommentOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeCommentWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Comment>(CommentOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeErrorWithJilSerializer()
        {
            return JilSerializer.Serialize(ErrorInput);
        }

        [Benchmark]
        public object SerializeErrorWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(ErrorInput);
        }

        [Benchmark]
        public object DeserializeErrorWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Error>(ErrorOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeErrorWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Error>(ErrorOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeEventWithJilSerializer()
        {
            return JilSerializer.Serialize(EventInput);
        }

        [Benchmark]
        public object SerializeEventWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(EventInput);
        }

        [Benchmark]
        public object DeserializeEventWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Event>(EventOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeEventWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Event>(EventOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileFeedWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileFeedInput);
        }

        [Benchmark]
        public object SerializeMobileFeedWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileFeedInput);
        }

        [Benchmark]
        public object DeserializeMobileFeedWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileFeed>(MobileFeedOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileFeedWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileFeed>(MobileFeedOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileQuestionWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileQuestionInput);
        }

        [Benchmark]
        public object SerializeMobileQuestionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileQuestionInput);
        }

        [Benchmark]
        public object DeserializeMobileQuestionWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileQuestion>(MobileQuestionOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileQuestionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileQuestion>(MobileQuestionOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileRepChangeWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileRepChangeInput);
        }

        [Benchmark]
        public object SerializeMobileRepChangeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileRepChangeInput);
        }

        [Benchmark]
        public object DeserializeMobileRepChangeWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileRepChange>(MobileRepChangeOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileRepChangeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileRepChange>(MobileRepChangeOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileInboxItemWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileInboxItemInput);
        }

        [Benchmark]
        public object SerializeMobileInboxItemWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileInboxItemInput);
        }

        [Benchmark]
        public object DeserializeMobileInboxItemWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileInboxItem>(MobileInboxItemOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileInboxItemWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileInboxItem>(MobileInboxItemOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileBadgeAwardWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileBadgeAwardInput);
        }

        [Benchmark]
        public object SerializeMobileBadgeAwardWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileBadgeAwardInput);
        }

        [Benchmark]
        public object DeserializeMobileBadgeAwardWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileBadgeAward>(MobileBadgeAwardOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileBadgeAwardWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBadgeAward>(MobileBadgeAwardOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobilePrivilegeWithJilSerializer()
        {
            return JilSerializer.Serialize(MobilePrivilegeInput);
        }

        [Benchmark]
        public object SerializeMobilePrivilegeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobilePrivilegeInput);
        }

        [Benchmark]
        public object DeserializeMobilePrivilegeWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobilePrivilege>(MobilePrivilegeOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobilePrivilegeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobilePrivilege>(MobilePrivilegeOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileCommunityBulletinWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileCommunityBulletinInput);
        }

        [Benchmark]
        public object SerializeMobileCommunityBulletinWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileCommunityBulletinInput);
        }

        [Benchmark]
        public object DeserializeMobileCommunityBulletinWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileCommunityBulletin>(MobileCommunityBulletinOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileCommunityBulletinWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileCommunityBulletin>(MobileCommunityBulletinOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileAssociationBonusWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileAssociationBonusInput);
        }

        [Benchmark]
        public object SerializeMobileAssociationBonusWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileAssociationBonusInput);
        }

        [Benchmark]
        public object DeserializeMobileAssociationBonusWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileAssociationBonus>(MobileAssociationBonusOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileAssociationBonusWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileAssociationBonus>(MobileAssociationBonusOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileCareersJobAdWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileCareersJobAdInput);
        }

        [Benchmark]
        public object SerializeMobileCareersJobAdWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileCareersJobAdInput);
        }

        [Benchmark]
        public object DeserializeMobileCareersJobAdWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileCareersJobAd>(MobileCareersJobAdOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileCareersJobAdWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileCareersJobAd>(MobileCareersJobAdOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileBannerAdWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileBannerAdInput);
        }

        [Benchmark]
        public object SerializeMobileBannerAdWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileBannerAdInput);
        }

        [Benchmark]
        public object DeserializeMobileBannerAdWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileBannerAd>(MobileBannerAdOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileBannerAdWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBannerAd>(MobileBannerAdOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileUpdateNoticeWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileUpdateNoticeInput);
        }

        [Benchmark]
        public object SerializeMobileUpdateNoticeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileUpdateNoticeInput);
        }

        [Benchmark]
        public object DeserializeMobileUpdateNoticeWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileUpdateNotice>(MobileUpdateNoticeOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileUpdateNoticeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileUpdateNotice>(MobileUpdateNoticeOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeFlagOptionWithJilSerializer()
        {
            return JilSerializer.Serialize(FlagOptionInput);
        }

        [Benchmark]
        public object SerializeFlagOptionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(FlagOptionInput);
        }

        [Benchmark]
        public object DeserializeFlagOptionWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.FlagOption>(FlagOptionOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeFlagOptionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.FlagOption>(FlagOptionOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeInboxItemWithJilSerializer()
        {
            return JilSerializer.Serialize(InboxItemInput);
        }

        [Benchmark]
        public object SerializeInboxItemWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(InboxItemInput);
        }

        [Benchmark]
        public object DeserializeInboxItemWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.InboxItem>(InboxItemOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeInboxItemWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.InboxItem>(InboxItemOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeInfoWithJilSerializer()
        {
            return JilSerializer.Serialize(InfoInput);
        }

        [Benchmark]
        public object SerializeInfoWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(InfoInput);
        }

        [Benchmark]
        public object DeserializeInfoWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Info>(InfoOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeInfoWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info>(InfoOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeNetworkUserWithJilSerializer()
        {
            return JilSerializer.Serialize(NetworkUserInput);
        }

        [Benchmark]
        public object SerializeNetworkUserWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(NetworkUserInput);
        }

        [Benchmark]
        public object DeserializeNetworkUserWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.NetworkUser>(NetworkUserOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeNetworkUserWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.NetworkUser>(NetworkUserOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeNotificationWithJilSerializer()
        {
            return JilSerializer.Serialize(NotificationInput);
        }

        [Benchmark]
        public object SerializeNotificationWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(NotificationInput);
        }

        [Benchmark]
        public object DeserializeNotificationWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Notification>(NotificationOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeNotificationWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Notification>(NotificationOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializePostWithJilSerializer()
        {
            return JilSerializer.Serialize(PostInput);
        }

        [Benchmark]
        public object SerializePostWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(PostInput);
        }

        [Benchmark]
        public object DeserializePostWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Post>(PostOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializePostWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Post>(PostOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializePrivilegeWithJilSerializer()
        {
            return JilSerializer.Serialize(PrivilegeInput);
        }

        [Benchmark]
        public object SerializePrivilegeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(PrivilegeInput);
        }

        [Benchmark]
        public object DeserializePrivilegeWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Privilege>(PrivilegeOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializePrivilegeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Privilege>(PrivilegeOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeQuestionWithJilSerializer()
        {
            return JilSerializer.Serialize(QuestionInput);
        }

        [Benchmark]
        public object SerializeQuestionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(QuestionInput);
        }

        [Benchmark]
        public object DeserializeQuestionWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Question>(QuestionOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeQuestionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question>(QuestionOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeQuestionTimelineWithJilSerializer()
        {
            return JilSerializer.Serialize(QuestionTimelineInput);
        }

        [Benchmark]
        public object SerializeQuestionTimelineWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(QuestionTimelineInput);
        }

        [Benchmark]
        public object DeserializeQuestionTimelineWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.QuestionTimeline>(QuestionTimelineOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeQuestionTimelineWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.QuestionTimeline>(QuestionTimelineOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeReputationWithJilSerializer()
        {
            return JilSerializer.Serialize(ReputationInput);
        }

        [Benchmark]
        public object SerializeReputationWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(ReputationInput);
        }

        [Benchmark]
        public object DeserializeReputationWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Reputation>(ReputationOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeReputationWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Reputation>(ReputationOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeReputationHistoryWithJilSerializer()
        {
            return JilSerializer.Serialize(ReputationHistoryInput);
        }

        [Benchmark]
        public object SerializeReputationHistoryWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(ReputationHistoryInput);
        }

        [Benchmark]
        public object DeserializeReputationHistoryWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.ReputationHistory>(ReputationHistoryOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeReputationHistoryWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.ReputationHistory>(ReputationHistoryOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeRevisionWithJilSerializer()
        {
            return JilSerializer.Serialize(RevisionInput);
        }

        [Benchmark]
        public object SerializeRevisionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(RevisionInput);
        }

        [Benchmark]
        public object DeserializeRevisionWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Revision>(RevisionOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeRevisionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Revision>(RevisionOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeSearchExcerptWithJilSerializer()
        {
            return JilSerializer.Serialize(SearchExcerptInput);
        }

        [Benchmark]
        public object SerializeSearchExcerptWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(SearchExcerptInput);
        }

        [Benchmark]
        public object DeserializeSearchExcerptWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.SearchExcerpt>(SearchExcerptOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeSearchExcerptWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.SearchExcerpt>(SearchExcerptOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeShallowUserWithJilSerializer()
        {
            return JilSerializer.Serialize(ShallowUserInput);
        }

        [Benchmark]
        public object SerializeShallowUserWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(ShallowUserInput);
        }

        [Benchmark]
        public object DeserializeShallowUserWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.ShallowUser>(ShallowUserOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeShallowUserWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.ShallowUser>(ShallowUserOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeSuggestedEditWithJilSerializer()
        {
            return JilSerializer.Serialize(SuggestedEditInput);
        }

        [Benchmark]
        public object SerializeSuggestedEditWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(SuggestedEditInput);
        }

        [Benchmark]
        public object DeserializeSuggestedEditWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.SuggestedEdit>(SuggestedEditOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeSuggestedEditWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.SuggestedEdit>(SuggestedEditOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeTagWithJilSerializer()
        {
            return JilSerializer.Serialize(TagInput);
        }

        [Benchmark]
        public object SerializeTagWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(TagInput);
        }

        [Benchmark]
        public object DeserializeTagWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Tag>(TagOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeTagWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Tag>(TagOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeTagScoreWithJilSerializer()
        {
            return JilSerializer.Serialize(TagScoreInput);
        }

        [Benchmark]
        public object SerializeTagScoreWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(TagScoreInput);
        }

        [Benchmark]
        public object DeserializeTagScoreWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.TagScore>(TagScoreOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeTagScoreWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagScore>(TagScoreOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeTagSynonymWithJilSerializer()
        {
            return JilSerializer.Serialize(TagSynonymInput);
        }

        [Benchmark]
        public object SerializeTagSynonymWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(TagSynonymInput);
        }

        [Benchmark]
        public object DeserializeTagSynonymWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.TagSynonym>(TagSynonymOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeTagSynonymWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagSynonym>(TagSynonymOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeTagWikiWithJilSerializer()
        {
            return JilSerializer.Serialize(TagWikiInput);
        }

        [Benchmark]
        public object SerializeTagWikiWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(TagWikiInput);
        }

        [Benchmark]
        public object DeserializeTagWikiWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.TagWiki>(TagWikiOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeTagWikiWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagWiki>(TagWikiOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeTopTagWithJilSerializer()
        {
            return JilSerializer.Serialize(TopTagInput);
        }

        [Benchmark]
        public object SerializeTopTagWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(TopTagInput);
        }

        [Benchmark]
        public object DeserializeTopTagWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.TopTag>(TopTagOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeTopTagWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.TopTag>(TopTagOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeUserWithJilSerializer()
        {
            return JilSerializer.Serialize(UserInput);
        }

        [Benchmark]
        public object SerializeUserWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(UserInput);
        }

        [Benchmark]
        public object DeserializeUserWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.User>(UserOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeUserWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.User>(UserOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeUserTimelineWithJilSerializer()
        {
            return JilSerializer.Serialize(UserTimelineInput);
        }

        [Benchmark]
        public object SerializeUserTimelineWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(UserTimelineInput);
        }

        [Benchmark]
        public object DeserializeUserTimelineWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.UserTimeline>(UserTimelineOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeUserTimelineWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.UserTimeline>(UserTimelineOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeWritePermissionWithJilSerializer()
        {
            return JilSerializer.Serialize(WritePermissionInput);
        }

        [Benchmark]
        public object SerializeWritePermissionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(WritePermissionInput);
        }

        [Benchmark]
        public object DeserializeWritePermissionWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.WritePermission>(WritePermissionOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeWritePermissionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.WritePermission>(WritePermissionOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMobileBannerAdImageWithJilSerializer()
        {
            return JilSerializer.Serialize(MobileBannerAdImageInput);
        }

        [Benchmark]
        public object SerializeMobileBannerAdImageWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MobileBannerAdImageInput);
        }

        [Benchmark]
        public object DeserializeMobileBannerAdImageWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>(MobileBannerAdImageOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMobileBannerAdImageWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>(MobileBannerAdImageOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeSiteWithJilSerializer()
        {
            return JilSerializer.Serialize(SiteInput);
        }

        [Benchmark]
        public object SerializeSiteWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(SiteInput);
        }

        [Benchmark]
        public object DeserializeSiteWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Info.Site>(SiteOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeSiteWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.Site>(SiteOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeRelatedSiteWithJilSerializer()
        {
            return JilSerializer.Serialize(RelatedSiteInput);
        }

        [Benchmark]
        public object SerializeRelatedSiteWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(RelatedSiteInput);
        }

        [Benchmark]
        public object DeserializeRelatedSiteWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Info.RelatedSite>(RelatedSiteOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeRelatedSiteWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.RelatedSite>(RelatedSiteOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeClosedDetailsWithJilSerializer()
        {
            return JilSerializer.Serialize(ClosedDetailsInput);
        }

        [Benchmark]
        public object SerializeClosedDetailsWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(ClosedDetailsInput);
        }

        [Benchmark]
        public object DeserializeClosedDetailsWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails>(ClosedDetailsOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeClosedDetailsWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails>(ClosedDetailsOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeNoticeWithJilSerializer()
        {
            return JilSerializer.Serialize(NoticeInput);
        }

        [Benchmark]
        public object SerializeNoticeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(NoticeInput);
        }

        [Benchmark]
        public object DeserializeNoticeWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Question.Notice>(NoticeOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeNoticeWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.Notice>(NoticeOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeMigrationInfoWithJilSerializer()
        {
            return JilSerializer.Serialize(MigrationInfoInput);
        }

        [Benchmark]
        public object SerializeMigrationInfoWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(MigrationInfoInput);
        }

        [Benchmark]
        public object DeserializeMigrationInfoWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Question.MigrationInfo>(MigrationInfoOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeMigrationInfoWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.MigrationInfo>(MigrationInfoOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeBadgeCountWithJilSerializer()
        {
            return JilSerializer.Serialize(BadgeCountInput);
        }

        [Benchmark]
        public object SerializeBadgeCountWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(BadgeCountInput);
        }

        [Benchmark]
        public object DeserializeBadgeCountWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.User.BadgeCount>(BadgeCountOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeBadgeCountWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.User.BadgeCount>(BadgeCountOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeStylingWithJilSerializer()
        {
            return JilSerializer.Serialize(StylingInput);
        }

        [Benchmark]
        public object SerializeStylingWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(StylingInput);
        }

        [Benchmark]
        public object DeserializeStylingWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Info.Site.Styling>(StylingOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeStylingWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.Site.Styling>(StylingOutputOfUtf8JsonSerializer);
        }

        [Benchmark]
        public object SerializeOriginalQuestionWithJilSerializer()
        {
            return JilSerializer.Serialize(OriginalQuestionInput);
        }

        [Benchmark]
        public object SerializeOriginalQuestionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Serialize(OriginalQuestionInput);
        }

        [Benchmark]
        public object DeserializeOriginalQuestionWithJilSerializer()
        {
            return JilSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>(OriginalQuestionOutputOfJilSerializer);
        }

        [Benchmark]
        public object DeserializeOriginalQuestionWithUtf8JsonSerializer()
        {
            return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>(OriginalQuestionOutputOfUtf8JsonSerializer);
        }
    }

    public class ModelBenchmark_Utf8Bytes : ModelBenchmarkBase<JilSerializer_Utf8Bytes, Utf8JsonSerializer_Utf8Bytes>
    {
        JilSerializer_Utf8Bytes jilserializeer = new JilSerializer_Utf8Bytes();
        Utf8JsonSerializer_Utf8Bytes utf8jsonserializer = new Utf8JsonSerializer_Utf8Bytes();

        protected override JilSerializer_Utf8Bytes JilSerializer => jilserializeer;

        protected override Utf8JsonSerializer_Utf8Bytes Utf8JsonSerializer => utf8jsonserializer;
    }

    public class ModelBenchmark_String : ModelBenchmarkBase<JilSerializer_String, Utf8JsonSerializer_String>
    {
        JilSerializer_String jilserializeer = new JilSerializer_String();
        Utf8JsonSerializer_String utf8jsonserializer = new Utf8JsonSerializer_String();

        protected override JilSerializer_String JilSerializer => jilserializeer;

        protected override Utf8JsonSerializer_String Utf8JsonSerializer => utf8jsonserializer;
    }

    public class ModelBenchmark_Utf8Stream : ModelBenchmarkBase<JilSerializer_Utf8Stream, Utf8JsonSerializer_Utf8Stream>
    {
        JilSerializer_Utf8Stream jilserializeer = new JilSerializer_Utf8Stream();
        Utf8JsonSerializer_Utf8Stream utf8jsonserializer = new Utf8JsonSerializer_Utf8Stream();

        protected override JilSerializer_Utf8Stream JilSerializer => jilserializeer;

        protected override Utf8JsonSerializer_Utf8Stream Utf8JsonSerializer => utf8jsonserializer;
    }
}
