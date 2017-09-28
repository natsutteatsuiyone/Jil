  
  
  
  
  
  
  
  
namespace Benchmark
{  
using Benchmark.Serializers;
using Benchmark.Models;
using Benchmark.Fixture;
using BenchmarkDotNet.Attributes;
  [Config(typeof(MyConfig))]
  public partial class ModelBenchmark
  {
	private static readonly ExpressionTreeFixture ExpressionTreeFixture = new ExpressionTreeFixture();
  
	private static readonly Benchmark.Serializers.JilSerializer JilSerializer = new Benchmark.Serializers.JilSerializer();
  
	private static readonly Benchmark.Serializers.Utf8JsonSerializer Utf8JsonSerializer = new Benchmark.Serializers.Utf8JsonSerializer();
  
  
	private static readonly Benchmark.Models.AccessToken AccessTokenInput = ExpressionTreeFixture.Create<Benchmark.Models.AccessToken>();
  
	private static readonly Benchmark.Models.AccountMerge AccountMergeInput = ExpressionTreeFixture.Create<Benchmark.Models.AccountMerge>();
  
	private static readonly Benchmark.Models.Answer AnswerInput = ExpressionTreeFixture.Create<Benchmark.Models.Answer>();
  
	private static readonly Benchmark.Models.Badge BadgeInput = ExpressionTreeFixture.Create<Benchmark.Models.Badge>();
  
	private static readonly Benchmark.Models.Comment CommentInput = ExpressionTreeFixture.Create<Benchmark.Models.Comment>();
  
	private static readonly Benchmark.Models.Error ErrorInput = ExpressionTreeFixture.Create<Benchmark.Models.Error>();
  
	private static readonly Benchmark.Models.Event EventInput = ExpressionTreeFixture.Create<Benchmark.Models.Event>();
  
	private static readonly Benchmark.Models.MobileFeed MobileFeedInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileFeed>();
  
	private static readonly Benchmark.Models.MobileQuestion MobileQuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileQuestion>();
  
	private static readonly Benchmark.Models.MobileRepChange MobileRepChangeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileRepChange>();
  
	private static readonly Benchmark.Models.MobileInboxItem MobileInboxItemInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileInboxItem>();
  
	private static readonly Benchmark.Models.MobileBadgeAward MobileBadgeAwardInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBadgeAward>();
  
	private static readonly Benchmark.Models.MobilePrivilege MobilePrivilegeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobilePrivilege>();
  
	private static readonly Benchmark.Models.MobileCommunityBulletin MobileCommunityBulletinInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileCommunityBulletin>();
  
	private static readonly Benchmark.Models.MobileAssociationBonus MobileAssociationBonusInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileAssociationBonus>();
  
	private static readonly Benchmark.Models.MobileCareersJobAd MobileCareersJobAdInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileCareersJobAd>();
  
	private static readonly Benchmark.Models.MobileBannerAd MobileBannerAdInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBannerAd>();
  
	private static readonly Benchmark.Models.MobileUpdateNotice MobileUpdateNoticeInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileUpdateNotice>();
  
	private static readonly Benchmark.Models.FlagOption FlagOptionInput = ExpressionTreeFixture.Create<Benchmark.Models.FlagOption>();
  
	private static readonly Benchmark.Models.InboxItem InboxItemInput = ExpressionTreeFixture.Create<Benchmark.Models.InboxItem>();
  
	private static readonly Benchmark.Models.Info InfoInput = ExpressionTreeFixture.Create<Benchmark.Models.Info>();
  
	private static readonly Benchmark.Models.NetworkUser NetworkUserInput = ExpressionTreeFixture.Create<Benchmark.Models.NetworkUser>();
  
	private static readonly Benchmark.Models.Notification NotificationInput = ExpressionTreeFixture.Create<Benchmark.Models.Notification>();
  
	private static readonly Benchmark.Models.Post PostInput = ExpressionTreeFixture.Create<Benchmark.Models.Post>();
  
	private static readonly Benchmark.Models.Privilege PrivilegeInput = ExpressionTreeFixture.Create<Benchmark.Models.Privilege>();
  
	private static readonly Benchmark.Models.Question QuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.Question>();
  
	private static readonly Benchmark.Models.QuestionTimeline QuestionTimelineInput = ExpressionTreeFixture.Create<Benchmark.Models.QuestionTimeline>();
  
	private static readonly Benchmark.Models.Reputation ReputationInput = ExpressionTreeFixture.Create<Benchmark.Models.Reputation>();
  
	private static readonly Benchmark.Models.ReputationHistory ReputationHistoryInput = ExpressionTreeFixture.Create<Benchmark.Models.ReputationHistory>();
  
	private static readonly Benchmark.Models.Revision RevisionInput = ExpressionTreeFixture.Create<Benchmark.Models.Revision>();
  
	private static readonly Benchmark.Models.SearchExcerpt SearchExcerptInput = ExpressionTreeFixture.Create<Benchmark.Models.SearchExcerpt>();
  
	private static readonly Benchmark.Models.ShallowUser ShallowUserInput = ExpressionTreeFixture.Create<Benchmark.Models.ShallowUser>();
  
	private static readonly Benchmark.Models.SuggestedEdit SuggestedEditInput = ExpressionTreeFixture.Create<Benchmark.Models.SuggestedEdit>();
  
	private static readonly Benchmark.Models.Tag TagInput = ExpressionTreeFixture.Create<Benchmark.Models.Tag>();
  
	private static readonly Benchmark.Models.TagScore TagScoreInput = ExpressionTreeFixture.Create<Benchmark.Models.TagScore>();
  
	private static readonly Benchmark.Models.TagSynonym TagSynonymInput = ExpressionTreeFixture.Create<Benchmark.Models.TagSynonym>();
  
	private static readonly Benchmark.Models.TagWiki TagWikiInput = ExpressionTreeFixture.Create<Benchmark.Models.TagWiki>();
  
	private static readonly Benchmark.Models.TopTag TopTagInput = ExpressionTreeFixture.Create<Benchmark.Models.TopTag>();
  
	private static readonly Benchmark.Models.User UserInput = ExpressionTreeFixture.Create<Benchmark.Models.User>();
  
	private static readonly Benchmark.Models.UserTimeline UserTimelineInput = ExpressionTreeFixture.Create<Benchmark.Models.UserTimeline>();
  
	private static readonly Benchmark.Models.WritePermission WritePermissionInput = ExpressionTreeFixture.Create<Benchmark.Models.WritePermission>();
  
	private static readonly Benchmark.Models.MobileBannerAd.MobileBannerAdImage MobileBannerAdImageInput = ExpressionTreeFixture.Create<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>();
  
	private static readonly Benchmark.Models.Info.Site SiteInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.Site>();
  
	private static readonly Benchmark.Models.Info.RelatedSite RelatedSiteInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.RelatedSite>();
  
	private static readonly Benchmark.Models.Question.ClosedDetails ClosedDetailsInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.ClosedDetails>();
  
	private static readonly Benchmark.Models.Question.Notice NoticeInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.Notice>();
  
	private static readonly Benchmark.Models.Question.MigrationInfo MigrationInfoInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.MigrationInfo>();
  
	private static readonly Benchmark.Models.User.BadgeCount BadgeCountInput = ExpressionTreeFixture.Create<Benchmark.Models.User.BadgeCount>();
  
	private static readonly Benchmark.Models.Info.Site.Styling StylingInput = ExpressionTreeFixture.Create<Benchmark.Models.Info.Site.Styling>();
  
	private static readonly Benchmark.Models.Question.ClosedDetails.OriginalQuestion OriginalQuestionInput = ExpressionTreeFixture.Create<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>();
  
  
	private static readonly object AccessTokenOutputOfJilSerializer = JilSerializer.Serialize(AccessTokenInput);

	[Benchmark]
	public object SerializeAccessTokenWithJilSerializer()
	{
		return JilSerializer.Serialize(AccessTokenInput);
	}
	[Benchmark]
	public object DeserializeAccessTokenWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.AccessToken>(AccessTokenOutputOfJilSerializer);
	}
  
	private static readonly object AccountMergeOutputOfJilSerializer = JilSerializer.Serialize(AccountMergeInput);

	[Benchmark]
	public object SerializeAccountMergeWithJilSerializer()
	{
		return JilSerializer.Serialize(AccountMergeInput);
	}
	[Benchmark]
	public object DeserializeAccountMergeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.AccountMerge>(AccountMergeOutputOfJilSerializer);
	}
  
	private static readonly object AnswerOutputOfJilSerializer = JilSerializer.Serialize(AnswerInput);

	[Benchmark]
	public object SerializeAnswerWithJilSerializer()
	{
		return JilSerializer.Serialize(AnswerInput);
	}
	[Benchmark]
	public object DeserializeAnswerWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Answer>(AnswerOutputOfJilSerializer);
	}
  
	private static readonly object BadgeOutputOfJilSerializer = JilSerializer.Serialize(BadgeInput);

	[Benchmark]
	public object SerializeBadgeWithJilSerializer()
	{
		return JilSerializer.Serialize(BadgeInput);
	}
	[Benchmark]
	public object DeserializeBadgeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Badge>(BadgeOutputOfJilSerializer);
	}
  
	private static readonly object CommentOutputOfJilSerializer = JilSerializer.Serialize(CommentInput);

	[Benchmark]
	public object SerializeCommentWithJilSerializer()
	{
		return JilSerializer.Serialize(CommentInput);
	}
	[Benchmark]
	public object DeserializeCommentWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Comment>(CommentOutputOfJilSerializer);
	}
  
	private static readonly object ErrorOutputOfJilSerializer = JilSerializer.Serialize(ErrorInput);

	[Benchmark]
	public object SerializeErrorWithJilSerializer()
	{
		return JilSerializer.Serialize(ErrorInput);
	}
	[Benchmark]
	public object DeserializeErrorWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Error>(ErrorOutputOfJilSerializer);
	}
  
	private static readonly object EventOutputOfJilSerializer = JilSerializer.Serialize(EventInput);

	[Benchmark]
	public object SerializeEventWithJilSerializer()
	{
		return JilSerializer.Serialize(EventInput);
	}
	[Benchmark]
	public object DeserializeEventWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Event>(EventOutputOfJilSerializer);
	}
  
	private static readonly object MobileFeedOutputOfJilSerializer = JilSerializer.Serialize(MobileFeedInput);

	[Benchmark]
	public object SerializeMobileFeedWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileFeedInput);
	}
	[Benchmark]
	public object DeserializeMobileFeedWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileFeed>(MobileFeedOutputOfJilSerializer);
	}
  
	private static readonly object MobileQuestionOutputOfJilSerializer = JilSerializer.Serialize(MobileQuestionInput);

	[Benchmark]
	public object SerializeMobileQuestionWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileQuestionInput);
	}
	[Benchmark]
	public object DeserializeMobileQuestionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileQuestion>(MobileQuestionOutputOfJilSerializer);
	}
  
	private static readonly object MobileRepChangeOutputOfJilSerializer = JilSerializer.Serialize(MobileRepChangeInput);

	[Benchmark]
	public object SerializeMobileRepChangeWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileRepChangeInput);
	}
	[Benchmark]
	public object DeserializeMobileRepChangeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileRepChange>(MobileRepChangeOutputOfJilSerializer);
	}
  
	private static readonly object MobileInboxItemOutputOfJilSerializer = JilSerializer.Serialize(MobileInboxItemInput);

	[Benchmark]
	public object SerializeMobileInboxItemWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileInboxItemInput);
	}
	[Benchmark]
	public object DeserializeMobileInboxItemWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileInboxItem>(MobileInboxItemOutputOfJilSerializer);
	}
  
	private static readonly object MobileBadgeAwardOutputOfJilSerializer = JilSerializer.Serialize(MobileBadgeAwardInput);

	[Benchmark]
	public object SerializeMobileBadgeAwardWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileBadgeAwardInput);
	}
	[Benchmark]
	public object DeserializeMobileBadgeAwardWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileBadgeAward>(MobileBadgeAwardOutputOfJilSerializer);
	}
  
	private static readonly object MobilePrivilegeOutputOfJilSerializer = JilSerializer.Serialize(MobilePrivilegeInput);

	[Benchmark]
	public object SerializeMobilePrivilegeWithJilSerializer()
	{
		return JilSerializer.Serialize(MobilePrivilegeInput);
	}
	[Benchmark]
	public object DeserializeMobilePrivilegeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobilePrivilege>(MobilePrivilegeOutputOfJilSerializer);
	}
  
	private static readonly object MobileCommunityBulletinOutputOfJilSerializer = JilSerializer.Serialize(MobileCommunityBulletinInput);

	[Benchmark]
	public object SerializeMobileCommunityBulletinWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileCommunityBulletinInput);
	}
	[Benchmark]
	public object DeserializeMobileCommunityBulletinWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileCommunityBulletin>(MobileCommunityBulletinOutputOfJilSerializer);
	}
  
	private static readonly object MobileAssociationBonusOutputOfJilSerializer = JilSerializer.Serialize(MobileAssociationBonusInput);

	[Benchmark]
	public object SerializeMobileAssociationBonusWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileAssociationBonusInput);
	}
	[Benchmark]
	public object DeserializeMobileAssociationBonusWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileAssociationBonus>(MobileAssociationBonusOutputOfJilSerializer);
	}
  
	private static readonly object MobileCareersJobAdOutputOfJilSerializer = JilSerializer.Serialize(MobileCareersJobAdInput);

	[Benchmark]
	public object SerializeMobileCareersJobAdWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileCareersJobAdInput);
	}
	[Benchmark]
	public object DeserializeMobileCareersJobAdWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileCareersJobAd>(MobileCareersJobAdOutputOfJilSerializer);
	}
  
	private static readonly object MobileBannerAdOutputOfJilSerializer = JilSerializer.Serialize(MobileBannerAdInput);

	[Benchmark]
	public object SerializeMobileBannerAdWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileBannerAdInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileBannerAd>(MobileBannerAdOutputOfJilSerializer);
	}
  
	private static readonly object MobileUpdateNoticeOutputOfJilSerializer = JilSerializer.Serialize(MobileUpdateNoticeInput);

	[Benchmark]
	public object SerializeMobileUpdateNoticeWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileUpdateNoticeInput);
	}
	[Benchmark]
	public object DeserializeMobileUpdateNoticeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileUpdateNotice>(MobileUpdateNoticeOutputOfJilSerializer);
	}
  
	private static readonly object FlagOptionOutputOfJilSerializer = JilSerializer.Serialize(FlagOptionInput);

	[Benchmark]
	public object SerializeFlagOptionWithJilSerializer()
	{
		return JilSerializer.Serialize(FlagOptionInput);
	}
	[Benchmark]
	public object DeserializeFlagOptionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.FlagOption>(FlagOptionOutputOfJilSerializer);
	}
  
	private static readonly object InboxItemOutputOfJilSerializer = JilSerializer.Serialize(InboxItemInput);

	[Benchmark]
	public object SerializeInboxItemWithJilSerializer()
	{
		return JilSerializer.Serialize(InboxItemInput);
	}
	[Benchmark]
	public object DeserializeInboxItemWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.InboxItem>(InboxItemOutputOfJilSerializer);
	}
  
	private static readonly object InfoOutputOfJilSerializer = JilSerializer.Serialize(InfoInput);

	[Benchmark]
	public object SerializeInfoWithJilSerializer()
	{
		return JilSerializer.Serialize(InfoInput);
	}
	[Benchmark]
	public object DeserializeInfoWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info>(InfoOutputOfJilSerializer);
	}
  
	private static readonly object NetworkUserOutputOfJilSerializer = JilSerializer.Serialize(NetworkUserInput);

	[Benchmark]
	public object SerializeNetworkUserWithJilSerializer()
	{
		return JilSerializer.Serialize(NetworkUserInput);
	}
	[Benchmark]
	public object DeserializeNetworkUserWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.NetworkUser>(NetworkUserOutputOfJilSerializer);
	}
  
	private static readonly object NotificationOutputOfJilSerializer = JilSerializer.Serialize(NotificationInput);

	[Benchmark]
	public object SerializeNotificationWithJilSerializer()
	{
		return JilSerializer.Serialize(NotificationInput);
	}
	[Benchmark]
	public object DeserializeNotificationWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Notification>(NotificationOutputOfJilSerializer);
	}
  
	private static readonly object PostOutputOfJilSerializer = JilSerializer.Serialize(PostInput);

	[Benchmark]
	public object SerializePostWithJilSerializer()
	{
		return JilSerializer.Serialize(PostInput);
	}
	[Benchmark]
	public object DeserializePostWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Post>(PostOutputOfJilSerializer);
	}
  
	private static readonly object PrivilegeOutputOfJilSerializer = JilSerializer.Serialize(PrivilegeInput);

	[Benchmark]
	public object SerializePrivilegeWithJilSerializer()
	{
		return JilSerializer.Serialize(PrivilegeInput);
	}
	[Benchmark]
	public object DeserializePrivilegeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Privilege>(PrivilegeOutputOfJilSerializer);
	}
  
	private static readonly object QuestionOutputOfJilSerializer = JilSerializer.Serialize(QuestionInput);

	[Benchmark]
	public object SerializeQuestionWithJilSerializer()
	{
		return JilSerializer.Serialize(QuestionInput);
	}
	[Benchmark]
	public object DeserializeQuestionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question>(QuestionOutputOfJilSerializer);
	}
  
	private static readonly object QuestionTimelineOutputOfJilSerializer = JilSerializer.Serialize(QuestionTimelineInput);

	[Benchmark]
	public object SerializeQuestionTimelineWithJilSerializer()
	{
		return JilSerializer.Serialize(QuestionTimelineInput);
	}
	[Benchmark]
	public object DeserializeQuestionTimelineWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.QuestionTimeline>(QuestionTimelineOutputOfJilSerializer);
	}
  
	private static readonly object ReputationOutputOfJilSerializer = JilSerializer.Serialize(ReputationInput);

	[Benchmark]
	public object SerializeReputationWithJilSerializer()
	{
		return JilSerializer.Serialize(ReputationInput);
	}
	[Benchmark]
	public object DeserializeReputationWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Reputation>(ReputationOutputOfJilSerializer);
	}
  
	private static readonly object ReputationHistoryOutputOfJilSerializer = JilSerializer.Serialize(ReputationHistoryInput);

	[Benchmark]
	public object SerializeReputationHistoryWithJilSerializer()
	{
		return JilSerializer.Serialize(ReputationHistoryInput);
	}
	[Benchmark]
	public object DeserializeReputationHistoryWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.ReputationHistory>(ReputationHistoryOutputOfJilSerializer);
	}
  
	private static readonly object RevisionOutputOfJilSerializer = JilSerializer.Serialize(RevisionInput);

	[Benchmark]
	public object SerializeRevisionWithJilSerializer()
	{
		return JilSerializer.Serialize(RevisionInput);
	}
	[Benchmark]
	public object DeserializeRevisionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Revision>(RevisionOutputOfJilSerializer);
	}
  
	private static readonly object SearchExcerptOutputOfJilSerializer = JilSerializer.Serialize(SearchExcerptInput);

	[Benchmark]
	public object SerializeSearchExcerptWithJilSerializer()
	{
		return JilSerializer.Serialize(SearchExcerptInput);
	}
	[Benchmark]
	public object DeserializeSearchExcerptWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.SearchExcerpt>(SearchExcerptOutputOfJilSerializer);
	}
  
	private static readonly object ShallowUserOutputOfJilSerializer = JilSerializer.Serialize(ShallowUserInput);

	[Benchmark]
	public object SerializeShallowUserWithJilSerializer()
	{
		return JilSerializer.Serialize(ShallowUserInput);
	}
	[Benchmark]
	public object DeserializeShallowUserWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.ShallowUser>(ShallowUserOutputOfJilSerializer);
	}
  
	private static readonly object SuggestedEditOutputOfJilSerializer = JilSerializer.Serialize(SuggestedEditInput);

	[Benchmark]
	public object SerializeSuggestedEditWithJilSerializer()
	{
		return JilSerializer.Serialize(SuggestedEditInput);
	}
	[Benchmark]
	public object DeserializeSuggestedEditWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.SuggestedEdit>(SuggestedEditOutputOfJilSerializer);
	}
  
	private static readonly object TagOutputOfJilSerializer = JilSerializer.Serialize(TagInput);

	[Benchmark]
	public object SerializeTagWithJilSerializer()
	{
		return JilSerializer.Serialize(TagInput);
	}
	[Benchmark]
	public object DeserializeTagWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Tag>(TagOutputOfJilSerializer);
	}
  
	private static readonly object TagScoreOutputOfJilSerializer = JilSerializer.Serialize(TagScoreInput);

	[Benchmark]
	public object SerializeTagScoreWithJilSerializer()
	{
		return JilSerializer.Serialize(TagScoreInput);
	}
	[Benchmark]
	public object DeserializeTagScoreWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TagScore>(TagScoreOutputOfJilSerializer);
	}
  
	private static readonly object TagSynonymOutputOfJilSerializer = JilSerializer.Serialize(TagSynonymInput);

	[Benchmark]
	public object SerializeTagSynonymWithJilSerializer()
	{
		return JilSerializer.Serialize(TagSynonymInput);
	}
	[Benchmark]
	public object DeserializeTagSynonymWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TagSynonym>(TagSynonymOutputOfJilSerializer);
	}
  
	private static readonly object TagWikiOutputOfJilSerializer = JilSerializer.Serialize(TagWikiInput);

	[Benchmark]
	public object SerializeTagWikiWithJilSerializer()
	{
		return JilSerializer.Serialize(TagWikiInput);
	}
	[Benchmark]
	public object DeserializeTagWikiWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TagWiki>(TagWikiOutputOfJilSerializer);
	}
  
	private static readonly object TopTagOutputOfJilSerializer = JilSerializer.Serialize(TopTagInput);

	[Benchmark]
	public object SerializeTopTagWithJilSerializer()
	{
		return JilSerializer.Serialize(TopTagInput);
	}
	[Benchmark]
	public object DeserializeTopTagWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.TopTag>(TopTagOutputOfJilSerializer);
	}
  
	private static readonly object UserOutputOfJilSerializer = JilSerializer.Serialize(UserInput);

	[Benchmark]
	public object SerializeUserWithJilSerializer()
	{
		return JilSerializer.Serialize(UserInput);
	}
	[Benchmark]
	public object DeserializeUserWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.User>(UserOutputOfJilSerializer);
	}
  
	private static readonly object UserTimelineOutputOfJilSerializer = JilSerializer.Serialize(UserTimelineInput);

	[Benchmark]
	public object SerializeUserTimelineWithJilSerializer()
	{
		return JilSerializer.Serialize(UserTimelineInput);
	}
	[Benchmark]
	public object DeserializeUserTimelineWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.UserTimeline>(UserTimelineOutputOfJilSerializer);
	}
  
	private static readonly object WritePermissionOutputOfJilSerializer = JilSerializer.Serialize(WritePermissionInput);

	[Benchmark]
	public object SerializeWritePermissionWithJilSerializer()
	{
		return JilSerializer.Serialize(WritePermissionInput);
	}
	[Benchmark]
	public object DeserializeWritePermissionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.WritePermission>(WritePermissionOutputOfJilSerializer);
	}
  
	private static readonly object MobileBannerAdImageOutputOfJilSerializer = JilSerializer.Serialize(MobileBannerAdImageInput);

	[Benchmark]
	public object SerializeMobileBannerAdImageWithJilSerializer()
	{
		return JilSerializer.Serialize(MobileBannerAdImageInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdImageWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>(MobileBannerAdImageOutputOfJilSerializer);
	}
  
	private static readonly object SiteOutputOfJilSerializer = JilSerializer.Serialize(SiteInput);

	[Benchmark]
	public object SerializeSiteWithJilSerializer()
	{
		return JilSerializer.Serialize(SiteInput);
	}
	[Benchmark]
	public object DeserializeSiteWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info.Site>(SiteOutputOfJilSerializer);
	}
  
	private static readonly object RelatedSiteOutputOfJilSerializer = JilSerializer.Serialize(RelatedSiteInput);

	[Benchmark]
	public object SerializeRelatedSiteWithJilSerializer()
	{
		return JilSerializer.Serialize(RelatedSiteInput);
	}
	[Benchmark]
	public object DeserializeRelatedSiteWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info.RelatedSite>(RelatedSiteOutputOfJilSerializer);
	}
  
	private static readonly object ClosedDetailsOutputOfJilSerializer = JilSerializer.Serialize(ClosedDetailsInput);

	[Benchmark]
	public object SerializeClosedDetailsWithJilSerializer()
	{
		return JilSerializer.Serialize(ClosedDetailsInput);
	}
	[Benchmark]
	public object DeserializeClosedDetailsWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails>(ClosedDetailsOutputOfJilSerializer);
	}
  
	private static readonly object NoticeOutputOfJilSerializer = JilSerializer.Serialize(NoticeInput);

	[Benchmark]
	public object SerializeNoticeWithJilSerializer()
	{
		return JilSerializer.Serialize(NoticeInput);
	}
	[Benchmark]
	public object DeserializeNoticeWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.Notice>(NoticeOutputOfJilSerializer);
	}
  
	private static readonly object MigrationInfoOutputOfJilSerializer = JilSerializer.Serialize(MigrationInfoInput);

	[Benchmark]
	public object SerializeMigrationInfoWithJilSerializer()
	{
		return JilSerializer.Serialize(MigrationInfoInput);
	}
	[Benchmark]
	public object DeserializeMigrationInfoWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.MigrationInfo>(MigrationInfoOutputOfJilSerializer);
	}
  
	private static readonly object BadgeCountOutputOfJilSerializer = JilSerializer.Serialize(BadgeCountInput);

	[Benchmark]
	public object SerializeBadgeCountWithJilSerializer()
	{
		return JilSerializer.Serialize(BadgeCountInput);
	}
	[Benchmark]
	public object DeserializeBadgeCountWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.User.BadgeCount>(BadgeCountOutputOfJilSerializer);
	}
  
	private static readonly object StylingOutputOfJilSerializer = JilSerializer.Serialize(StylingInput);

	[Benchmark]
	public object SerializeStylingWithJilSerializer()
	{
		return JilSerializer.Serialize(StylingInput);
	}
	[Benchmark]
	public object DeserializeStylingWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Info.Site.Styling>(StylingOutputOfJilSerializer);
	}
  
	private static readonly object OriginalQuestionOutputOfJilSerializer = JilSerializer.Serialize(OriginalQuestionInput);

	[Benchmark]
	public object SerializeOriginalQuestionWithJilSerializer()
	{
		return JilSerializer.Serialize(OriginalQuestionInput);
	}
	[Benchmark]
	public object DeserializeOriginalQuestionWithJilSerializer()
	{
		return JilSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails.OriginalQuestion>(OriginalQuestionOutputOfJilSerializer);
	}
  
	private static readonly object AccessTokenOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AccessTokenInput);

	[Benchmark]
	public object SerializeAccessTokenWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(AccessTokenInput);
	}
	[Benchmark]
	public object DeserializeAccessTokenWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.AccessToken>(AccessTokenOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object AccountMergeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AccountMergeInput);

	[Benchmark]
	public object SerializeAccountMergeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(AccountMergeInput);
	}
	[Benchmark]
	public object DeserializeAccountMergeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.AccountMerge>(AccountMergeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object AnswerOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(AnswerInput);

	[Benchmark]
	public object SerializeAnswerWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(AnswerInput);
	}
	[Benchmark]
	public object DeserializeAnswerWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Answer>(AnswerOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object BadgeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(BadgeInput);

	[Benchmark]
	public object SerializeBadgeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(BadgeInput);
	}
	[Benchmark]
	public object DeserializeBadgeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Badge>(BadgeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object CommentOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(CommentInput);

	[Benchmark]
	public object SerializeCommentWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(CommentInput);
	}
	[Benchmark]
	public object DeserializeCommentWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Comment>(CommentOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object ErrorOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ErrorInput);

	[Benchmark]
	public object SerializeErrorWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ErrorInput);
	}
	[Benchmark]
	public object DeserializeErrorWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Error>(ErrorOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object EventOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(EventInput);

	[Benchmark]
	public object SerializeEventWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(EventInput);
	}
	[Benchmark]
	public object DeserializeEventWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Event>(EventOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileFeedOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileFeedInput);

	[Benchmark]
	public object SerializeMobileFeedWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileFeedInput);
	}
	[Benchmark]
	public object DeserializeMobileFeedWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileFeed>(MobileFeedOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileQuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileQuestionInput);

	[Benchmark]
	public object SerializeMobileQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileQuestionInput);
	}
	[Benchmark]
	public object DeserializeMobileQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileQuestion>(MobileQuestionOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileRepChangeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileRepChangeInput);

	[Benchmark]
	public object SerializeMobileRepChangeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileRepChangeInput);
	}
	[Benchmark]
	public object DeserializeMobileRepChangeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileRepChange>(MobileRepChangeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileInboxItemOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileInboxItemInput);

	[Benchmark]
	public object SerializeMobileInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileInboxItemInput);
	}
	[Benchmark]
	public object DeserializeMobileInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileInboxItem>(MobileInboxItemOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileBadgeAwardOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBadgeAwardInput);

	[Benchmark]
	public object SerializeMobileBadgeAwardWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileBadgeAwardInput);
	}
	[Benchmark]
	public object DeserializeMobileBadgeAwardWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBadgeAward>(MobileBadgeAwardOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobilePrivilegeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobilePrivilegeInput);

	[Benchmark]
	public object SerializeMobilePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobilePrivilegeInput);
	}
	[Benchmark]
	public object DeserializeMobilePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobilePrivilege>(MobilePrivilegeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileCommunityBulletinOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileCommunityBulletinInput);

	[Benchmark]
	public object SerializeMobileCommunityBulletinWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileCommunityBulletinInput);
	}
	[Benchmark]
	public object DeserializeMobileCommunityBulletinWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileCommunityBulletin>(MobileCommunityBulletinOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileAssociationBonusOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileAssociationBonusInput);

	[Benchmark]
	public object SerializeMobileAssociationBonusWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileAssociationBonusInput);
	}
	[Benchmark]
	public object DeserializeMobileAssociationBonusWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileAssociationBonus>(MobileAssociationBonusOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileCareersJobAdOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileCareersJobAdInput);

	[Benchmark]
	public object SerializeMobileCareersJobAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileCareersJobAdInput);
	}
	[Benchmark]
	public object DeserializeMobileCareersJobAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileCareersJobAd>(MobileCareersJobAdOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileBannerAdOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBannerAdInput);

	[Benchmark]
	public object SerializeMobileBannerAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileBannerAdInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBannerAd>(MobileBannerAdOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileUpdateNoticeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileUpdateNoticeInput);

	[Benchmark]
	public object SerializeMobileUpdateNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileUpdateNoticeInput);
	}
	[Benchmark]
	public object DeserializeMobileUpdateNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileUpdateNotice>(MobileUpdateNoticeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object FlagOptionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(FlagOptionInput);

	[Benchmark]
	public object SerializeFlagOptionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(FlagOptionInput);
	}
	[Benchmark]
	public object DeserializeFlagOptionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.FlagOption>(FlagOptionOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object InboxItemOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(InboxItemInput);

	[Benchmark]
	public object SerializeInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(InboxItemInput);
	}
	[Benchmark]
	public object DeserializeInboxItemWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.InboxItem>(InboxItemOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object InfoOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(InfoInput);

	[Benchmark]
	public object SerializeInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(InfoInput);
	}
	[Benchmark]
	public object DeserializeInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info>(InfoOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object NetworkUserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NetworkUserInput);

	[Benchmark]
	public object SerializeNetworkUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(NetworkUserInput);
	}
	[Benchmark]
	public object DeserializeNetworkUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.NetworkUser>(NetworkUserOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object NotificationOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NotificationInput);

	[Benchmark]
	public object SerializeNotificationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(NotificationInput);
	}
	[Benchmark]
	public object DeserializeNotificationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Notification>(NotificationOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object PostOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(PostInput);

	[Benchmark]
	public object SerializePostWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(PostInput);
	}
	[Benchmark]
	public object DeserializePostWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Post>(PostOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object PrivilegeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(PrivilegeInput);

	[Benchmark]
	public object SerializePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(PrivilegeInput);
	}
	[Benchmark]
	public object DeserializePrivilegeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Privilege>(PrivilegeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object QuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(QuestionInput);

	[Benchmark]
	public object SerializeQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(QuestionInput);
	}
	[Benchmark]
	public object DeserializeQuestionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question>(QuestionOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object QuestionTimelineOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(QuestionTimelineInput);

	[Benchmark]
	public object SerializeQuestionTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(QuestionTimelineInput);
	}
	[Benchmark]
	public object DeserializeQuestionTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.QuestionTimeline>(QuestionTimelineOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object ReputationOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ReputationInput);

	[Benchmark]
	public object SerializeReputationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ReputationInput);
	}
	[Benchmark]
	public object DeserializeReputationWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Reputation>(ReputationOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object ReputationHistoryOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ReputationHistoryInput);

	[Benchmark]
	public object SerializeReputationHistoryWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ReputationHistoryInput);
	}
	[Benchmark]
	public object DeserializeReputationHistoryWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.ReputationHistory>(ReputationHistoryOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object RevisionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(RevisionInput);

	[Benchmark]
	public object SerializeRevisionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(RevisionInput);
	}
	[Benchmark]
	public object DeserializeRevisionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Revision>(RevisionOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object SearchExcerptOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SearchExcerptInput);

	[Benchmark]
	public object SerializeSearchExcerptWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SearchExcerptInput);
	}
	[Benchmark]
	public object DeserializeSearchExcerptWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.SearchExcerpt>(SearchExcerptOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object ShallowUserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ShallowUserInput);

	[Benchmark]
	public object SerializeShallowUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ShallowUserInput);
	}
	[Benchmark]
	public object DeserializeShallowUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.ShallowUser>(ShallowUserOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object SuggestedEditOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SuggestedEditInput);

	[Benchmark]
	public object SerializeSuggestedEditWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SuggestedEditInput);
	}
	[Benchmark]
	public object DeserializeSuggestedEditWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.SuggestedEdit>(SuggestedEditOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object TagOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagInput);

	[Benchmark]
	public object SerializeTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagInput);
	}
	[Benchmark]
	public object DeserializeTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Tag>(TagOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object TagScoreOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagScoreInput);

	[Benchmark]
	public object SerializeTagScoreWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagScoreInput);
	}
	[Benchmark]
	public object DeserializeTagScoreWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagScore>(TagScoreOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object TagSynonymOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagSynonymInput);

	[Benchmark]
	public object SerializeTagSynonymWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagSynonymInput);
	}
	[Benchmark]
	public object DeserializeTagSynonymWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagSynonym>(TagSynonymOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object TagWikiOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TagWikiInput);

	[Benchmark]
	public object SerializeTagWikiWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TagWikiInput);
	}
	[Benchmark]
	public object DeserializeTagWikiWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TagWiki>(TagWikiOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object TopTagOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(TopTagInput);

	[Benchmark]
	public object SerializeTopTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(TopTagInput);
	}
	[Benchmark]
	public object DeserializeTopTagWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.TopTag>(TopTagOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object UserOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UserInput);

	[Benchmark]
	public object SerializeUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UserInput);
	}
	[Benchmark]
	public object DeserializeUserWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.User>(UserOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object UserTimelineOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(UserTimelineInput);

	[Benchmark]
	public object SerializeUserTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(UserTimelineInput);
	}
	[Benchmark]
	public object DeserializeUserTimelineWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.UserTimeline>(UserTimelineOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object WritePermissionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(WritePermissionInput);

	[Benchmark]
	public object SerializeWritePermissionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(WritePermissionInput);
	}
	[Benchmark]
	public object DeserializeWritePermissionWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.WritePermission>(WritePermissionOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MobileBannerAdImageOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MobileBannerAdImageInput);

	[Benchmark]
	public object SerializeMobileBannerAdImageWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MobileBannerAdImageInput);
	}
	[Benchmark]
	public object DeserializeMobileBannerAdImageWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.MobileBannerAd.MobileBannerAdImage>(MobileBannerAdImageOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object SiteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(SiteInput);

	[Benchmark]
	public object SerializeSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(SiteInput);
	}
	[Benchmark]
	public object DeserializeSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.Site>(SiteOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object RelatedSiteOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(RelatedSiteInput);

	[Benchmark]
	public object SerializeRelatedSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(RelatedSiteInput);
	}
	[Benchmark]
	public object DeserializeRelatedSiteWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.RelatedSite>(RelatedSiteOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object ClosedDetailsOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(ClosedDetailsInput);

	[Benchmark]
	public object SerializeClosedDetailsWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(ClosedDetailsInput);
	}
	[Benchmark]
	public object DeserializeClosedDetailsWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.ClosedDetails>(ClosedDetailsOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object NoticeOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(NoticeInput);

	[Benchmark]
	public object SerializeNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(NoticeInput);
	}
	[Benchmark]
	public object DeserializeNoticeWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.Notice>(NoticeOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object MigrationInfoOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(MigrationInfoInput);

	[Benchmark]
	public object SerializeMigrationInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(MigrationInfoInput);
	}
	[Benchmark]
	public object DeserializeMigrationInfoWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Question.MigrationInfo>(MigrationInfoOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object BadgeCountOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(BadgeCountInput);

	[Benchmark]
	public object SerializeBadgeCountWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(BadgeCountInput);
	}
	[Benchmark]
	public object DeserializeBadgeCountWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.User.BadgeCount>(BadgeCountOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object StylingOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(StylingInput);

	[Benchmark]
	public object SerializeStylingWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Serialize(StylingInput);
	}
	[Benchmark]
	public object DeserializeStylingWithUtf8JsonSerializer()
	{
		return Utf8JsonSerializer.Deserialize<Benchmark.Models.Info.Site.Styling>(StylingOutputOfUtf8JsonSerializer);
	}
  
	private static readonly object OriginalQuestionOutputOfUtf8JsonSerializer = Utf8JsonSerializer.Serialize(OriginalQuestionInput);

	[Benchmark]
	public object SerializeOriginalQuestionWithUtf8JsonSerializer()
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
  