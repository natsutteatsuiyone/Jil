  
  
  
  
  
  
  
  
namespace Benchmark
{  
using Benchmark.Serializers;
using Benchmark.Models;
using Benchmark.Fixture;
using BenchmarkDotNet.Attributes;
  [Config(typeof(MyConfig))]
  public partial class ModelBenchmark
  {
	private readonly static ExpressionTreeFixture ExpressionTreeFixture = new ExpressionTreeFixture();
  
	private readonly static Benchmark.Serializers.JilSerializer JilSerializer = new Benchmark.Serializers.JilSerializer();
  
	private readonly static Benchmark.Serializers.Utf8JsonSerializer Utf8JsonSerializer = new Benchmark.Serializers.Utf8JsonSerializer();
  
  
	private readonly static Benchmark.Models.AccessToken AccessTokenInput = ExpressionTreeFixture.Create<Benchmark.Models.AccessToken>();
  
	private readonly static Benchmark.Models.AccountMerge AccountMergeInput = ExpressionTreeFixture.Create<Benchmark.Models.AccountMerge>();
  
	private readonly static Benchmark.Models.Answer AnswerInput = ExpressionTreeFixture.Create<Benchmark.Models.Answer>();
  
	private readonly static Benchmark.Models.Badge BadgeInput = ExpressionTreeFixture.Create<Benchmark.Models.Badge>();
  
	private readonly static Benchmark.Models.Comment CommentInput = ExpressionTreeFixture.Create<Benchmark.Models.Comment>();
  
	private readonly static Benchmark.Models.Error ErrorInput = ExpressionTreeFixture.Create<Benchmark.Models.Error>();
  
	private readonly static Benchmark.Models.Event EventInput = ExpressionTreeFixture.Create<Benchmark.Models.Event>();
  
	private readonly static Benchmark.Models.MobileFeed MobileFeedInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileFeed>();
  
	private readonly static Benchmark.Models.MobileQuestion MobileQuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileQuestion>();
  
	private readonly static Benchmark.Models.MobileRepChange MobileRepChangeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileRepChange>();
  
	private readonly static Benchmark.Models.MobileInboxItem MobileInboxItemInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileInboxItem>();
  
	private readonly static Benchmark.Models.MobileBadgeAward MobileBadgeAwardInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBadgeAward>();
  
	private readonly static Benchmark.Models.MobilePrivilege MobilePrivilegeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobilePrivilege>();
  
	private readonly static Benchmark.Models.MobileCommunityBulletin MobileCommunityBulletinInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileCommunityBulletin>();
  
	private readonly static Benchmark.Models.MobileAssociationBonus MobileAssociationBonusInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileAssociationBonus>();
  
	private readonly static Benchmark.Models.MobileCareersJobAd MobileCareersJobAdInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileCareersJobAd>();
  
	private readonly static Benchmark.Models.MobileBannerAd MobileBannerAdInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBannerAd>();
  
	private readonly static Benchmark.Models.MobileUpdateNotice MobileUpdateNoticeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileUpdateNotice>();
  
	private readonly static Benchmark.Models.FlagOption FlagOptionInput = ExpressionTreeFixture.Create<Benchmark.Models.FlagOption>();
  
	private readonly static Benchmark.Models.InboxItem InboxItemInput = ExpressionTreeFixture.Create<Benchmark.Models.InboxItem>();
  
	private readonly static Benchmark.Models.Info InfoInput = ExpressionTreeFixture.Create<Benchmark.Models.Info>();
  
	private readonly static Benchmark.Models.NetworkUser NetworkUserInput = ExpressionTreeFixture.Create<Benchmark.Models.NetworkUser>();
  
	private readonly static Benchmark.Models.Notification NotificationInput = ExpressionTreeFixture.Create<Benchmark.Models.Notification>();
  
	private readonly static Benchmark.Models.Post PostInput = ExpressionTreeFixture.Create<Benchmark.Models.Post>();
  
	private readonly static Benchmark.Models.Privilege PrivilegeInput = ExpressionTreeFixture.Create<Benchmark.Models.Privilege>();
  
	private readonly static Benchmark.Models.Question QuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.Question>();
  
	private readonly static Benchmark.Models.QuestionTimeline QuestionTimelineInput = ExpressionTreeFixture.Create<Benchmark.Models.QuestionTimeline>();
  
	private readonly static Benchmark.Models.Reputation ReputationInput = ExpressionTreeFixture.Create<Benchmark.Models.Reputation>();
  
	private readonly static Benchmark.Models.ReputationHistory ReputationHistoryInput = ExpressionTreeFixture.Create<Benchmark.Models.ReputationHistory>();
  
	private readonly static Benchmark.Models.Revision RevisionInput = ExpressionTreeFixture.Create<Benchmark.Models.Revision>();
  
	private readonly static Benchmark.Models.SearchExcerpt SearchExcerptInput = ExpressionTreeFixture.Create<Benchmark.Models.SearchExcerpt>();
  
	private readonly static Benchmark.Models.ShallowUser ShallowUserInput = ExpressionTreeFixture.Create<Benchmark.Models.ShallowUser>();
  
	private readonly static Benchmark.Models.SuggestedEdit SuggestedEditInput = ExpressionTreeFixture.Create<Benchmark.Models.SuggestedEdit>();
  
	private readonly static Benchmark.Models.Tag TagInput = ExpressionTreeFixture.Create<Benchmark.Models.Tag>();
  
	private readonly static Benchmark.Models.TagScore TagScoreInput = ExpressionTreeFixture.Create<Benchmark.Models.TagScore>();
  
	private readonly static Benchmark.Models.TagSynonym TagSynonymInput = ExpressionTreeFixture.Create<Benchmark.Models.TagSynonym>();
  
	private readonly static Benchmark.Models.TagWiki TagWikiInput = ExpressionTreeFixture.Create<Benchmark.Models.TagWiki>();
  
	private readonly static Benchmark.Models.TopTag TopTagInput = ExpressionTreeFixture.Create<Benchmark.Models.TopTag>();
  
	private readonly static Benchmark.Models.User UserInput = ExpressionTreeFixture.Create<Benchmark.Models.User>();
  
	private readonly static Benchmark.Models.UserTimeline UserTimelineInput = ExpressionTreeFixture.Create<Benchmark.Models.UserTimeline>();
  
	private readonly static Benchmark.Models.WritePermission WritePermissionInput = ExpressionTreeFixture.Create<Benchmark.Models.WritePermission>();
  
	private readonly static Benchmark.Models.MobileBannerAd.MobileBannerAdImage MobileBannerAdImageInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>();
  
	private readonly static Benchmark.Models.Info.Site SiteInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.Site>();
  
	private readonly static Benchmark.Models.Info.RelatedSite RelatedSiteInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.RelatedSite>();
  
	private readonly static Benchmark.Models.Question.ClosedDetails ClosedDetailsInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.ClosedDetails>();
  
	private readonly static Benchmark.Models.Question.Notice NoticeInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.Notice>();
  
	private readonly static Benchmark.Models.Question.MigrationInfo MigrationInfoInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.MigrationInfo>();
  
	private readonly static Benchmark.Models.User.BadgeCount BadgeCountInput = ExpressionTreeFixture.Create<Benchmark.Models.User.BadgeCount>();
  
	private readonly static Benchmark.Models.Info.Site.Styling StylingInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.Site.Styling>();
  
	private readonly static Benchmark.Models.Question.ClosedDetails.OriginalQuestion OriginalQuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>();
  
  
	private readonly static string AccessTokenOutputOfJilSerializer = JilSerializer.Serialize(AccessTokenInput);

	[Benchmark]
	public string SerializeAccessTokenWithJilSerializer()
	{
		return JilSerializer.Serialize(AccessTokenInput);
	}
	[Benchmark]
	public object DeserializeAccessTokenWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.AccessToken>(AccessTokenOutputOfJilSerializer);
	}
  
	private readonly static string AccountMergeOutputOfJilSerializer = JilSerializer.Serialize(AccountMergeInput);

	[Benchmark]
	public string SerializeAccountMergeWithJilSerializer()
	{
		return JilSerializer.Serialize(AccountMergeInput);
	}
	[Benchmark]
	public object DeserializeAccountMergeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.AccountMerge>(AccountMergeOutputOfJilSerializer);
	}
  
	private readonly static string AnswerOutputOfJilSerializer = JilSerializer.Serialize(AnswerInput);

	[Benchmark]
	public string SerializeAnswerWithJilSerializer()
	{
		return JilSerializer.Serialize(AnswerInput);
	}
	[Benchmark]
	public object DeserializeAnswerWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Answer>(AnswerOutputOfJilSerializer);
	}
  
	private readonly static string BadgeOutputOfJilSerializer = JilSerializer.Serialize(BadgeInput);

	[Benchmark]
	public string SerializeBadgeWithJilSerializer()
	{
		return JilSerializer.Serialize(BadgeInput);
	}
	[Benchmark]
	public object DeserializeBadgeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Badge>(BadgeOutputOfJilSerializer);
	}
  
	private readonly static string CommentOutputOfJilSerializer = JilSerializer.Serialize(CommentInput);

	[Benchmark]
	public string SerializeCommentWithJilSerializer()
	{
		return JilSerializer.Serialize(CommentInput);
	}
	[Benchmark]
	public object DeserializeCommentWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Comment>(CommentOutputOfJilSerializer);
	}
  
	private readonly static string ErrorOutputOfJilSerializer = JilSerializer.Serialize(ErrorInput);

	[Benchmark]
	public string SerializeErrorWithJilSerializer()
	{
		return JilSerializer.Serialize(ErrorInput);
	}
	[Benchmark]
	public object DeserializeErrorWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Error>(ErrorOutputOfJilSerializer);
	}
  
	private readonly static string EventOutputOfJilSerializer = JilSerializer.Serialize(EventInput);

	[Benchmark]
	public string SerializeEventWithJilSerializer()
	{
		return JilSerializer.Serialize(EventInput);
	}
	[Benchmark]
	public object DeserializeEventWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Event>(EventOutputOfJilSerializer);
	}
  
	private readonly static string MobileFeedOutputOfJilSerializer = JilSerializer.Serialize(MobileFeedInput);

	[Benchmark]
	public string SerializeMobileFeedWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileFeedInput);
	}
	[Benchmark]
	public object DeserializeMobileFeedWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileFeed>(MobileFeedOutputOfJilSerializer);
	}
  
	private readonly static string MobileQuestionOutputOfJilSerializer = JilSerializer.Serialize(MobileQuestionInput);

	[Benchmark]
	public string SerializeMobileQuestionWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileQuestionInput);
	}
	[Benchmark]
	public object DeserializeMobileQuestionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileQuestion>(MobileQuestionOutputOfJilSerializer);
	}
  
	private readonly static string MobileRepChangeOutputOfJilSerializer = JilSerializer.Serialize(MobileRepChangeInput);

	[Benchmark]
	public string SerializeMobileRepChangeWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileRepChangeInput);
	}
	[Benchmark]
	public object DeserializeMobileRepChangeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileRepChange>(MobileRepChangeOutputOfJilSerializer);
	}
  
	private readonly static string MobileInboxItemOutputOfJilSerializer = JilSerializer.Serialize(MobileInboxItemInput);

	[Benchmark]
	public string SerializeMobileInboxItemWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileInboxItemInput);
	}
	[Benchmark]
	public object DeserializeMobileInboxItemWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileInboxItem>(MobileInboxItemOutputOfJilSerializer);
	}
  
	private readonly static string MobileBadgeAwardOutputOfJilSerializer = JilSerializer.Serialize(MobileBadgeAwardInput);

	[Benchmark]
	public string SerializeMobileBadgeAwardWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileBadgeAwardInput);
	}
	[Benchmark]
	public object DeserializeMobileBadgeAwardWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileBadgeAward>(MobileBadgeAwardOutputOfJilSerializer);
	}
  
	private readonly static string MobilePrivilegeOutputOfJilSerializer = JilSerializer.Serialize(MobilePrivilegeInput);

	[Benchmark]
	public string SerializeMobilePrivilegeWithJilSerializer()
	{
		return JilSerializer.Serialize(MobilePrivilegeInput);
	}
	[Benchmark]
	public object DeserializeMobilePrivilegeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobilePrivilege>(MobilePrivilegeOutputOfJilSerializer);
	}
  
	private readonly static string MobileCommunityBulletinOutputOfJilSerializer = JilSerializer.Serialize(MobileCommunityBulletinInput);

	[Benchmark]
	public string SerializeMobileCommunityBulletinWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileCommunityBulletinInput);
	}
	[Benchmark]
	public object DeserializeMobileCommunityBulletinWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileCommunityBulletin>(MobileCommunityBulletinOutputOfJilSerializer);
	}
  
	private readonly static string MobileAssociationBonusOutputOfJilSerializer = JilSerializer.Serialize(MobileAssociationBonusInput);

	[Benchmark]
	public string SerializeMobileAssociationBonusWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileAssociationBonusInput);
	}
	[Benchmark]
	public object DeserializeMobileAssociationBonusWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileAssociationBonus>(MobileAssociationBonusOutputOfJilSerializer);
	}
  
	private readonly static string MobileCareersJobAdOutputOfJilSerializer = JilSerializer.Serialize(MobileCareersJobAdInput);

	[Benchmark]
	public string SerializeMobileCareersJobAdWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileCareersJobAdInput);
	}
	[Benchmark]
	public object DeserializeMobileCareersJobAdWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileCareersJobAd>(MobileCareersJobAdOutputOfJilSerializer);
	}
  
	private readonly static string MobileBannerAdOutputOfJilSerializer = JilSerializer.Serialize(MobileBannerAdInput);

	[Benchmark]
	public string SerializeMobileBannerAdWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileBannerAdInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileBannerAd>(MobileBannerAdOutputOfJilSerializer);
	}
  
	private readonly static string MobileUpdateNoticeOutputOfJilSerializer = JilSerializer.Serialize(MobileUpdateNoticeInput);

	[Benchmark]
	public string SerializeMobileUpdateNoticeWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileUpdateNoticeInput);
	}
	[Benchmark]
	public object DeserializeMobileUpdateNoticeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileUpdateNotice>(MobileUpdateNoticeOutputOfJilSerializer);
	}
  
	private readonly static string FlagOptionOutputOfJilSerializer = JilSerializer.Serialize(FlagOptionInput);

	[Benchmark]
	public string SerializeFlagOptionWithJilSerializer()
	{
		return JilSerializer.Serialize(FlagOptionInput);
	}
	[Benchmark]
	public object DeserializeFlagOptionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.FlagOption>(FlagOptionOutputOfJilSerializer);
	}
  
	private readonly static string InboxItemOutputOfJilSerializer = JilSerializer.Serialize(InboxItemInput);

	[Benchmark]
	public string SerializeInboxItemWithJilSerializer()
	{
		return JilSerializer.Serialize(InboxItemInput);
	}
	[Benchmark]
	public object DeserializeInboxItemWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.InboxItem>(InboxItemOutputOfJilSerializer);
	}
  
	private readonly static string InfoOutputOfJilSerializer = JilSerializer.Serialize(InfoInput);

	[Benchmark]
	public string SerializeInfoWithJilSerializer()
	{
		return JilSerializer.Serialize(InfoInput);
	}
	[Benchmark]
	public object DeserializeInfoWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info>(InfoOutputOfJilSerializer);
	}
  
	private readonly static string NetworkUserOutputOfJilSerializer = JilSerializer.Serialize(NetworkUserInput);

	[Benchmark]
	public string SerializeNetworkUserWithJilSerializer()
	{
		return JilSerializer.Serialize(NetworkUserInput);
	}
	[Benchmark]
	public object DeserializeNetworkUserWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.NetworkUser>(NetworkUserOutputOfJilSerializer);
	}
  
	private readonly static string NotificationOutputOfJilSerializer = JilSerializer.Serialize(NotificationInput);

	[Benchmark]
	public string SerializeNotificationWithJilSerializer()
	{
		return JilSerializer.Serialize(NotificationInput);
	}
	[Benchmark]
	public object DeserializeNotificationWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Notification>(NotificationOutputOfJilSerializer);
	}
  
	private readonly static string PostOutputOfJilSerializer = JilSerializer.Serialize(PostInput);

	[Benchmark]
	public string SerializePostWithJilSerializer()
	{
		return JilSerializer.Serialize(PostInput);
	}
	[Benchmark]
	public object DeserializePostWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Post>(PostOutputOfJilSerializer);
	}
  
	private readonly static string PrivilegeOutputOfJilSerializer = JilSerializer.Serialize(PrivilegeInput);

	[Benchmark]
	public string SerializePrivilegeWithJilSerializer()
	{
		return JilSerializer.Serialize(PrivilegeInput);
	}
	[Benchmark]
	public object DeserializePrivilegeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Privilege>(PrivilegeOutputOfJilSerializer);
	}
  
	private readonly static string QuestionOutputOfJilSerializer = JilSerializer.Serialize(QuestionInput);

	[Benchmark]
	public string SerializeQuestionWithJilSerializer()
	{
		return JilSerializer.Serialize(QuestionInput);
	}
	[Benchmark]
	public object DeserializeQuestionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question>(QuestionOutputOfJilSerializer);
	}
  
	private readonly static string QuestionTimelineOutputOfJilSerializer = JilSerializer.Serialize(QuestionTimelineInput);

	[Benchmark]
	public string SerializeQuestionTimelineWithJilSerializer()
	{
		return JilSerializer.Serialize(QuestionTimelineInput);
	}
	[Benchmark]
	public object DeserializeQuestionTimelineWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.QuestionTimeline>(QuestionTimelineOutputOfJilSerializer);
	}
  
	private readonly static string ReputationOutputOfJilSerializer = JilSerializer.Serialize(ReputationInput);

	[Benchmark]
	public string SerializeReputationWithJilSerializer()
	{
		return JilSerializer.Serialize(ReputationInput);
	}
	[Benchmark]
	public object DeserializeReputationWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Reputation>(ReputationOutputOfJilSerializer);
	}
  
	private readonly static string ReputationHistoryOutputOfJilSerializer = JilSerializer.Serialize(ReputationHistoryInput);

	[Benchmark]
	public string SerializeReputationHistoryWithJilSerializer()
	{
		return JilSerializer.Serialize(ReputationHistoryInput);
	}
	[Benchmark]
	public object DeserializeReputationHistoryWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.ReputationHistory>(ReputationHistoryOutputOfJilSerializer);
	}
  
	private readonly static string RevisionOutputOfJilSerializer = JilSerializer.Serialize(RevisionInput);

	[Benchmark]
	public string SerializeRevisionWithJilSerializer()
	{
		return JilSerializer.Serialize(RevisionInput);
	}
	[Benchmark]
	public object DeserializeRevisionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Revision>(RevisionOutputOfJilSerializer);
	}
  
	private readonly static string SearchExcerptOutputOfJilSerializer = JilSerializer.Serialize(SearchExcerptInput);

	[Benchmark]
	public string SerializeSearchExcerptWithJilSerializer()
	{
		return JilSerializer.Serialize(SearchExcerptInput);
	}
	[Benchmark]
	public object DeserializeSearchExcerptWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.SearchExcerpt>(SearchExcerptOutputOfJilSerializer);
	}
  
	private readonly static string ShallowUserOutputOfJilSerializer = JilSerializer.Serialize(ShallowUserInput);

	[Benchmark]
	public string SerializeShallowUserWithJilSerializer()
	{
		return JilSerializer.Serialize(ShallowUserInput);
	}
	[Benchmark]
	public object DeserializeShallowUserWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.ShallowUser>(ShallowUserOutputOfJilSerializer);
	}
  
	private readonly static string SuggestedEditOutputOfJilSerializer = JilSerializer.Serialize(SuggestedEditInput);

	[Benchmark]
	public string SerializeSuggestedEditWithJilSerializer()
	{
		return JilSerializer.Serialize(SuggestedEditInput);
	}
	[Benchmark]
	public object DeserializeSuggestedEditWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.SuggestedEdit>(SuggestedEditOutputOfJilSerializer);
	}
  
	private readonly static string TagOutputOfJilSerializer = JilSerializer.Serialize(TagInput);

	[Benchmark]
	public string SerializeTagWithJilSerializer()
	{
		return JilSerializer.Serialize(TagInput);
	}
	[Benchmark]
	public object DeserializeTagWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Tag>(TagOutputOfJilSerializer);
	}
  
	private readonly static string TagScoreOutputOfJilSerializer = JilSerializer.Serialize(TagScoreInput);

	[Benchmark]
	public string SerializeTagScoreWithJilSerializer()
	{
		return JilSerializer.Serialize(TagScoreInput);
	}
	[Benchmark]
	public object DeserializeTagScoreWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TagScore>(TagScoreOutputOfJilSerializer);
	}
  
	private readonly static string TagSynonymOutputOfJilSerializer = JilSerializer.Serialize(TagSynonymInput);

	[Benchmark]
	public string SerializeTagSynonymWithJilSerializer()
	{
		return JilSerializer.Serialize(TagSynonymInput);
	}
	[Benchmark]
	public object DeserializeTagSynonymWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TagSynonym>(TagSynonymOutputOfJilSerializer);
	}
  
	private readonly static string TagWikiOutputOfJilSerializer = JilSerializer.Serialize(TagWikiInput);

	[Benchmark]
	public string SerializeTagWikiWithJilSerializer()
	{
		return JilSerializer.Serialize(TagWikiInput);
	}
	[Benchmark]
	public object DeserializeTagWikiWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TagWiki>(TagWikiOutputOfJilSerializer);
	}
  
	private readonly static string TopTagOutputOfJilSerializer = JilSerializer.Serialize(TopTagInput);

	[Benchmark]
	public string SerializeTopTagWithJilSerializer()
	{
		return JilSerializer.Serialize(TopTagInput);
	}
	[Benchmark]
	public object DeserializeTopTagWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TopTag>(TopTagOutputOfJilSerializer);
	}
  
	private readonly static string UserOutputOfJilSerializer = JilSerializer.Serialize(UserInput);

	[Benchmark]
	public string SerializeUserWithJilSerializer()
	{
		return JilSerializer.Serialize(UserInput);
	}
	[Benchmark]
	public object DeserializeUserWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.User>(UserOutputOfJilSerializer);
	}
  
	private readonly static string UserTimelineOutputOfJilSerializer = JilSerializer.Serialize(UserTimelineInput);

	[Benchmark]
	public string SerializeUserTimelineWithJilSerializer()
	{
		return JilSerializer.Serialize(UserTimelineInput);
	}
	[Benchmark]
	public object DeserializeUserTimelineWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.UserTimeline>(UserTimelineOutputOfJilSerializer);
	}
  
	private readonly static string WritePermissionOutputOfJilSerializer = JilSerializer.Serialize(WritePermissionInput);

	[Benchmark]
	public string SerializeWritePermissionWithJilSerializer()
	{
		return JilSerializer.Serialize(WritePermissionInput);
	}
	[Benchmark]
	public object DeserializeWritePermissionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.WritePermission>(WritePermissionOutputOfJilSerializer);
	}
  
	private readonly static string MobileBannerAdImageOutputOfJilSerializer = JilSerializer.Serialize(MobileBannerAdImageInput);

	[Benchmark]
	public string SerializeMobileBannerAdImageWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileBannerAdImageInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdImageWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>(MobileBannerAdImageOutputOfJilSerializer);
	}
  
	private readonly static string SiteOutputOfJilSerializer = JilSerializer.Serialize(SiteInput);

	[Benchmark]
	public string SerializeSiteWithJilSerializer()
	{
		return JilSerializer.Serialize(SiteInput);
	}
	[Benchmark]
	public object DeserializeSiteWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info.Site>(SiteOutputOfJilSerializer);
	}
  
	private readonly static string RelatedSiteOutputOfJilSerializer = JilSerializer.Serialize(RelatedSiteInput);

	[Benchmark]
	public string SerializeRelatedSiteWithJilSerializer()
	{
		return JilSerializer.Serialize(RelatedSiteInput);
	}
	[Benchmark]
	public object DeserializeRelatedSiteWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info.RelatedSite>(RelatedSiteOutputOfJilSerializer);
	}
  
	private readonly static string ClosedDetailsOutputOfJilSerializer = JilSerializer.Serialize(ClosedDetailsInput);

	[Benchmark]
	public string SerializeClosedDetailsWithJilSerializer()
	{
		return JilSerializer.Serialize(ClosedDetailsInput);
	}
	[Benchmark]
	public object DeserializeClosedDetailsWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails>(ClosedDetailsOutputOfJilSerializer);
	}
  
	private readonly static string NoticeOutputOfJilSerializer = JilSerializer.Serialize(NoticeInput);

	[Benchmark]
	public string SerializeNoticeWithJilSerializer()
	{
		return JilSerializer.Serialize(NoticeInput);
	}
	[Benchmark]
	public object DeserializeNoticeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.Notice>(NoticeOutputOfJilSerializer);
	}
  
	private readonly static string MigrationInfoOutputOfJilSerializer = JilSerializer.Serialize(MigrationInfoInput);

	[Benchmark]
	public string SerializeMigrationInfoWithJilSerializer()
	{
		return JilSerializer.Serialize(MigrationInfoInput);
	}
	[Benchmark]
	public object DeserializeMigrationInfoWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.MigrationInfo>(MigrationInfoOutputOfJilSerializer);
	}
  
	private readonly static string BadgeCountOutputOfJilSerializer = JilSerializer.Serialize(BadgeCountInput);

	[Benchmark]
	public string SerializeBadgeCountWithJilSerializer()
	{
		return JilSerializer.Serialize(BadgeCountInput);
	}
	[Benchmark]
	public object DeserializeBadgeCountWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.User.BadgeCount>(BadgeCountOutputOfJilSerializer);
	}
  
	private readonly static string StylingOutputOfJilSerializer = JilSerializer.Serialize(StylingInput);

	[Benchmark]
	public string SerializeStylingWithJilSerializer()
	{
		return JilSerializer.Serialize(StylingInput);
	}
	[Benchmark]
	public object DeserializeStylingWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info.Site.Styling>(StylingOutputOfJilSerializer);
	}
  
	private readonly static string OriginalQuestionOutputOfJilSerializer = JilSerializer.Serialize(OriginalQuestionInput);

	[Benchmark]
	public string SerializeOriginalQuestionWithJilSerializer()
	{
		return JilSerializer.Serialize(OriginalQuestionInput);
	}
	[Benchmark]
	public object DeserializeOriginalQuestionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>(OriginalQuestionOutputOfJilSerializer);
	}
  
	private readonly static string AccessTokenOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AccessTokenInput);

	[Benchmark]
	public string SerializeAccessTokenWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(AccessTokenInput);
	}
	[Benchmark]
	public object DeserializeAccessTokenWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.AccessToken>(AccessTokenOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string AccountMergeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AccountMergeInput);

	[Benchmark]
	public string SerializeAccountMergeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(AccountMergeInput);
	}
	[Benchmark]
	public object DeserializeAccountMergeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.AccountMerge>(AccountMergeOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string AnswerOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AnswerInput);

	[Benchmark]
	public string SerializeAnswerWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(AnswerInput);
	}
	[Benchmark]
	public object DeserializeAnswerWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Answer>(AnswerOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string BadgeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(BadgeInput);

	[Benchmark]
	public string SerializeBadgeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(BadgeInput);
	}
	[Benchmark]
	public object DeserializeBadgeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Badge>(BadgeOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string CommentOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(CommentInput);

	[Benchmark]
	public string SerializeCommentWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(CommentInput);
	}
	[Benchmark]
	public object DeserializeCommentWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Comment>(CommentOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string ErrorOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ErrorInput);

	[Benchmark]
	public string SerializeErrorWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ErrorInput);
	}
	[Benchmark]
	public object DeserializeErrorWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Error>(ErrorOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string EventOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(EventInput);

	[Benchmark]
	public string SerializeEventWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(EventInput);
	}
	[Benchmark]
	public object DeserializeEventWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Event>(EventOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileFeedOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileFeedInput);

	[Benchmark]
	public string SerializeMobileFeedWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileFeedInput);
	}
	[Benchmark]
	public object DeserializeMobileFeedWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileFeed>(MobileFeedOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileQuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileQuestionInput);

	[Benchmark]
	public string SerializeMobileQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileQuestionInput);
	}
	[Benchmark]
	public object DeserializeMobileQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileQuestion>(MobileQuestionOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileRepChangeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileRepChangeInput);

	[Benchmark]
	public string SerializeMobileRepChangeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileRepChangeInput);
	}
	[Benchmark]
	public object DeserializeMobileRepChangeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileRepChange>(MobileRepChangeOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileInboxItemOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileInboxItemInput);

	[Benchmark]
	public string SerializeMobileInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileInboxItemInput);
	}
	[Benchmark]
	public object DeserializeMobileInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileInboxItem>(MobileInboxItemOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileBadgeAwardOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBadgeAwardInput);

	[Benchmark]
	public string SerializeMobileBadgeAwardWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileBadgeAwardInput);
	}
	[Benchmark]
	public object DeserializeMobileBadgeAwardWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBadgeAward>(MobileBadgeAwardOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobilePrivilegeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobilePrivilegeInput);

	[Benchmark]
	public string SerializeMobilePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobilePrivilegeInput);
	}
	[Benchmark]
	public object DeserializeMobilePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobilePrivilege>(MobilePrivilegeOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileCommunityBulletinOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileCommunityBulletinInput);

	[Benchmark]
	public string SerializeMobileCommunityBulletinWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileCommunityBulletinInput);
	}
	[Benchmark]
	public object DeserializeMobileCommunityBulletinWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileCommunityBulletin>(MobileCommunityBulletinOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileAssociationBonusOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileAssociationBonusInput);

	[Benchmark]
	public string SerializeMobileAssociationBonusWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileAssociationBonusInput);
	}
	[Benchmark]
	public object DeserializeMobileAssociationBonusWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileAssociationBonus>(MobileAssociationBonusOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileCareersJobAdOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileCareersJobAdInput);

	[Benchmark]
	public string SerializeMobileCareersJobAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileCareersJobAdInput);
	}
	[Benchmark]
	public object DeserializeMobileCareersJobAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileCareersJobAd>(MobileCareersJobAdOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileBannerAdOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBannerAdInput);

	[Benchmark]
	public string SerializeMobileBannerAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileBannerAdInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBannerAd>(MobileBannerAdOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileUpdateNoticeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileUpdateNoticeInput);

	[Benchmark]
	public string SerializeMobileUpdateNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileUpdateNoticeInput);
	}
	[Benchmark]
	public object DeserializeMobileUpdateNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileUpdateNotice>(MobileUpdateNoticeOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string FlagOptionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(FlagOptionInput);

	[Benchmark]
	public string SerializeFlagOptionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(FlagOptionInput);
	}
	[Benchmark]
	public object DeserializeFlagOptionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.FlagOption>(FlagOptionOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string InboxItemOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(InboxItemInput);

	[Benchmark]
	public string SerializeInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(InboxItemInput);
	}
	[Benchmark]
	public object DeserializeInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.InboxItem>(InboxItemOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string InfoOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(InfoInput);

	[Benchmark]
	public string SerializeInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(InfoInput);
	}
	[Benchmark]
	public object DeserializeInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info>(InfoOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string NetworkUserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NetworkUserInput);

	[Benchmark]
	public string SerializeNetworkUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(NetworkUserInput);
	}
	[Benchmark]
	public object DeserializeNetworkUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.NetworkUser>(NetworkUserOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string NotificationOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NotificationInput);

	[Benchmark]
	public string SerializeNotificationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(NotificationInput);
	}
	[Benchmark]
	public object DeserializeNotificationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Notification>(NotificationOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string PostOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(PostInput);

	[Benchmark]
	public string SerializePostWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(PostInput);
	}
	[Benchmark]
	public object DeserializePostWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Post>(PostOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string PrivilegeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(PrivilegeInput);

	[Benchmark]
	public string SerializePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(PrivilegeInput);
	}
	[Benchmark]
	public object DeserializePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Privilege>(PrivilegeOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string QuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(QuestionInput);

	[Benchmark]
	public string SerializeQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(QuestionInput);
	}
	[Benchmark]
	public object DeserializeQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question>(QuestionOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string QuestionTimelineOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(QuestionTimelineInput);

	[Benchmark]
	public string SerializeQuestionTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(QuestionTimelineInput);
	}
	[Benchmark]
	public object DeserializeQuestionTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.QuestionTimeline>(QuestionTimelineOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string ReputationOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ReputationInput);

	[Benchmark]
	public string SerializeReputationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ReputationInput);
	}
	[Benchmark]
	public object DeserializeReputationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Reputation>(ReputationOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string ReputationHistoryOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ReputationHistoryInput);

	[Benchmark]
	public string SerializeReputationHistoryWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ReputationHistoryInput);
	}
	[Benchmark]
	public object DeserializeReputationHistoryWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.ReputationHistory>(ReputationHistoryOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string RevisionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(RevisionInput);

	[Benchmark]
	public string SerializeRevisionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(RevisionInput);
	}
	[Benchmark]
	public object DeserializeRevisionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Revision>(RevisionOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string SearchExcerptOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SearchExcerptInput);

	[Benchmark]
	public string SerializeSearchExcerptWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SearchExcerptInput);
	}
	[Benchmark]
	public object DeserializeSearchExcerptWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.SearchExcerpt>(SearchExcerptOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string ShallowUserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ShallowUserInput);

	[Benchmark]
	public string SerializeShallowUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ShallowUserInput);
	}
	[Benchmark]
	public object DeserializeShallowUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.ShallowUser>(ShallowUserOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string SuggestedEditOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SuggestedEditInput);

	[Benchmark]
	public string SerializeSuggestedEditWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SuggestedEditInput);
	}
	[Benchmark]
	public object DeserializeSuggestedEditWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.SuggestedEdit>(SuggestedEditOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string TagOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagInput);

	[Benchmark]
	public string SerializeTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagInput);
	}
	[Benchmark]
	public object DeserializeTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Tag>(TagOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string TagScoreOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagScoreInput);

	[Benchmark]
	public string SerializeTagScoreWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagScoreInput);
	}
	[Benchmark]
	public object DeserializeTagScoreWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagScore>(TagScoreOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string TagSynonymOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagSynonymInput);

	[Benchmark]
	public string SerializeTagSynonymWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagSynonymInput);
	}
	[Benchmark]
	public object DeserializeTagSynonymWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagSynonym>(TagSynonymOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string TagWikiOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagWikiInput);

	[Benchmark]
	public string SerializeTagWikiWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagWikiInput);
	}
	[Benchmark]
	public object DeserializeTagWikiWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagWiki>(TagWikiOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string TopTagOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TopTagInput);

	[Benchmark]
	public string SerializeTopTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TopTagInput);
	}
	[Benchmark]
	public object DeserializeTopTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TopTag>(TopTagOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string UserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UserInput);

	[Benchmark]
	public string SerializeUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UserInput);
	}
	[Benchmark]
	public object DeserializeUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.User>(UserOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string UserTimelineOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UserTimelineInput);

	[Benchmark]
	public string SerializeUserTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UserTimelineInput);
	}
	[Benchmark]
	public object DeserializeUserTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.UserTimeline>(UserTimelineOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string WritePermissionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(WritePermissionInput);

	[Benchmark]
	public string SerializeWritePermissionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(WritePermissionInput);
	}
	[Benchmark]
	public object DeserializeWritePermissionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.WritePermission>(WritePermissionOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MobileBannerAdImageOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBannerAdImageInput);

	[Benchmark]
	public string SerializeMobileBannerAdImageWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileBannerAdImageInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdImageWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>(MobileBannerAdImageOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string SiteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SiteInput);

	[Benchmark]
	public string SerializeSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SiteInput);
	}
	[Benchmark]
	public object DeserializeSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.Site>(SiteOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string RelatedSiteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(RelatedSiteInput);

	[Benchmark]
	public string SerializeRelatedSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(RelatedSiteInput);
	}
	[Benchmark]
	public object DeserializeRelatedSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.RelatedSite>(RelatedSiteOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string ClosedDetailsOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ClosedDetailsInput);

	[Benchmark]
	public string SerializeClosedDetailsWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ClosedDetailsInput);
	}
	[Benchmark]
	public object DeserializeClosedDetailsWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails>(ClosedDetailsOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string NoticeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NoticeInput);

	[Benchmark]
	public string SerializeNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(NoticeInput);
	}
	[Benchmark]
	public object DeserializeNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.Notice>(NoticeOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string MigrationInfoOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MigrationInfoInput);

	[Benchmark]
	public string SerializeMigrationInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MigrationInfoInput);
	}
	[Benchmark]
	public object DeserializeMigrationInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.MigrationInfo>(MigrationInfoOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string BadgeCountOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(BadgeCountInput);

	[Benchmark]
	public string SerializeBadgeCountWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(BadgeCountInput);
	}
	[Benchmark]
	public object DeserializeBadgeCountWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.User.BadgeCount>(BadgeCountOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string StylingOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(StylingInput);

	[Benchmark]
	public string SerializeStylingWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(StylingInput);
	}
	[Benchmark]
	public object DeserializeStylingWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.Site.Styling>(StylingOutputOfUtf8JsonSerializer);
	}
  
	private readonly static string OriginalQuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(OriginalQuestionInput);

	[Benchmark]
	public string SerializeOriginalQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(OriginalQuestionInput);
	}
	[Benchmark]
	public object DeserializeOriginalQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>(OriginalQuestionOutputOfUtf8JsonSerializer);
	}
 

  }
}
  