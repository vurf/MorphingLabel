using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace MorphingLabel
{
	[BaseType (typeof(UILabel))]
	interface TOMSMorphingLabel
	{
		// @property (readonly, atomic, strong) NSString * targetText;
		[Export ("targetText", ArgumentSemantic.Strong)]
		string TargetText { get; }

		// @property (assign, nonatomic) CGFloat animationDuration;
		[Export ("animationDuration", ArgumentSemantic.Assign)]
		nfloat AnimationDuration { get; set; }

		// @property (assign, nonatomic) CGFloat characterAnimationOffset;
		[Export ("characterAnimationOffset", ArgumentSemantic.Assign)]
		nfloat CharacterAnimationOffset { get; set; }

		// @property (assign, nonatomic) CGFloat characterShrinkFactor;
		[Export ("characterShrinkFactor", ArgumentSemantic.Assign)]
		nfloat CharacterShrinkFactor { get; set; }

		// @property (getter = isMorphingEnabled, assign, nonatomic) BOOL morphingEnabled;
		[Export ("morphingEnabled")]
		bool MorphingEnabled { [Bind ("isMorphingEnabled")] get; set; }

		// +(void)setTextWithoutMorphing:(NSString *)text;
		[Static]
		[Export ("setTextWithoutMorphing:")]
		void SetTextWithoutMorphing (string text);

		// +(void)setText:(NSString *)text withCompletionBlock:(void (^)(void))block;
		[Static]
		[Export ("setText:withCompletionBlock:")]
		void SetText (string text, Action block);
	}
}

