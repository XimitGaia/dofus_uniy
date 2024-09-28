using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009F6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractiveElement : IMessage<InteractiveElement>, IMessage, IEquatable<InteractiveElement>, IDeepCloneable<InteractiveElement>, IBufferMessage
{
	[Token(Token = "0x20009F7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20009F8")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class InteractiveElementSkill : IMessage<InteractiveElementSkill>, IMessage, IEquatable<InteractiveElementSkill>, IDeepCloneable<InteractiveElementSkill>, IBufferMessage
		{
			[Token(Token = "0x4002395")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<InteractiveElementSkill> _parser;

			[Token(Token = "0x4002396")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002397")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4002398")]
			public const int SkillIdFieldNumber = 1;

			[Token(Token = "0x4002399")]
			[FieldOffset(Offset = "0x1C")]
			private int skillId_;

			[Token(Token = "0x400239A")]
			public const int SkillInstanceUidFieldNumber = 2;

			[Token(Token = "0x400239B")]
			[FieldOffset(Offset = "0x20")]
			private int skillInstanceUid_;

			[Token(Token = "0x400239C")]
			public const int NameIdFieldNumber = 3;

			[Token(Token = "0x400239D")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int NameIdDefaultValue;

			[Token(Token = "0x400239E")]
			[FieldOffset(Offset = "0x24")]
			private int nameId_;

			[Token(Token = "0x1700165F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<InteractiveElementSkill> Parser
			{
				[Token(Token = "0x6006809")]
				[Address(RVA = "0xBAB080", Offset = "0xBAA480", VA = "0x180BAB080")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001660")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600680A")]
				[Address(RVA = "0xBAAF90", Offset = "0xBAA390", VA = "0x180BAAF90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001661")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600680B")]
				[Address(RVA = "0xBAB1B0", Offset = "0xBAA5B0", VA = "0x180BAB1B0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001662")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int SkillId
			{
				[Token(Token = "0x600680F")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006810")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001663")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SkillInstanceUid
			{
				[Token(Token = "0x6006811")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006812")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17001664")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int NameId
			{
				[Token(Token = "0x6006813")]
				[Address(RVA = "0xBAB010", Offset = "0xBAA410", VA = "0x180BAB010")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006814")]
				[Address(RVA = "0x945AB0", Offset = "0x944EB0", VA = "0x180945AB0")]
				set
				{
				}
			}

			[Token(Token = "0x17001665")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasNameId
			{
				[Token(Token = "0x6006815")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600680C")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public InteractiveElementSkill()
			{
			}

			[Token(Token = "0x600680D")]
			[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public InteractiveElementSkill(InteractiveElementSkill other)
			{
			}

			[Token(Token = "0x600680E")]
			[Address(RVA = "0xBAAAF0", Offset = "0xBA9EF0", VA = "0x180BAAAF0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public InteractiveElementSkill Clone()
			{
				return null;
			}

			[Token(Token = "0x6006816")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearNameId()
			{
			}

			[Token(Token = "0x6006817")]
			[Address(RVA = "0xBAAB80", Offset = "0xBA9F80", VA = "0x180BAAB80", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006818")]
			[Address(RVA = "0xBAAC40", Offset = "0xBAA040", VA = "0x180BAAC40", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(InteractiveElementSkill other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006819")]
			[Address(RVA = "0xBAACC0", Offset = "0xBAA0C0", VA = "0x180BAACC0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600681A")]
			[Address(RVA = "0xBAAE20", Offset = "0xBAA220", VA = "0x180BAAE20", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600681B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600681C")]
			[Address(RVA = "0xBAB0D0", Offset = "0xBAA4D0", VA = "0x180BAB0D0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600681D")]
			[Address(RVA = "0xBAA9C0", Offset = "0xBA9DC0", VA = "0x180BAA9C0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600681E")]
			[Address(RVA = "0xBAADB0", Offset = "0xBAA1B0", VA = "0x180BAADB0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(InteractiveElementSkill other)
			{
			}

			[Token(Token = "0x600681F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006820")]
			[Address(RVA = "0x945820", Offset = "0x944C20", VA = "0x180945820", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002383")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InteractiveElement> _parser;

	[Token(Token = "0x4002384")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002385")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002386")]
	public const int ElementIdFieldNumber = 1;

	[Token(Token = "0x4002387")]
	[FieldOffset(Offset = "0x1C")]
	private int elementId_;

	[Token(Token = "0x4002388")]
	public const int ElementTypeIdFieldNumber = 2;

	[Token(Token = "0x4002389")]
	[FieldOffset(Offset = "0x20")]
	private int elementTypeId_;

	[Token(Token = "0x400238A")]
	public const int EnabledSkillsFieldNumber = 3;

	[Token(Token = "0x400238B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.InteractiveElementSkill> _repeated_enabledSkills_codec;

	[Token(Token = "0x400238C")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<Types.InteractiveElementSkill> enabledSkills_;

	[Token(Token = "0x400238D")]
	public const int DisabledSkillsFieldNumber = 4;

	[Token(Token = "0x400238E")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Types.InteractiveElementSkill> _repeated_disabledSkills_codec;

	[Token(Token = "0x400238F")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<Types.InteractiveElementSkill> disabledSkills_;

	[Token(Token = "0x4002390")]
	public const int OnCurrentMapFieldNumber = 5;

	[Token(Token = "0x4002391")]
	[FieldOffset(Offset = "0x38")]
	private bool onCurrentMap_;

	[Token(Token = "0x4002392")]
	public const int AgeBonusFieldNumber = 6;

	[Token(Token = "0x4002393")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int AgeBonusDefaultValue;

	[Token(Token = "0x4002394")]
	[FieldOffset(Offset = "0x3C")]
	private int ageBonus_;

	[Token(Token = "0x17001655")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractiveElement> Parser
	{
		[Token(Token = "0x60067EC")]
		[Address(RVA = "0xBABF00", Offset = "0xBAB300", VA = "0x180BABF00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001656")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60067ED")]
		[Address(RVA = "0xBABE50", Offset = "0xBAB250", VA = "0x180BABE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001657")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60067EE")]
		[Address(RVA = "0xBAC300", Offset = "0xBAB700", VA = "0x180BAC300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001658")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ElementId
	{
		[Token(Token = "0x60067F2")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60067F3")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001659")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ElementTypeId
	{
		[Token(Token = "0x60067F4")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60067F5")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700165A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.InteractiveElementSkill> EnabledSkills
	{
		[Token(Token = "0x60067F6")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700165B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.InteractiveElementSkill> DisabledSkills
	{
		[Token(Token = "0x60067F7")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700165C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OnCurrentMap
	{
		[Token(Token = "0x60067F8")]
		[Address(RVA = "0x9C5FF0", Offset = "0x9C53F0", VA = "0x1809C5FF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60067F9")]
		[Address(RVA = "0x9C6730", Offset = "0x9C5B30", VA = "0x1809C6730")]
		set
		{
		}
	}

	[Token(Token = "0x1700165D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AgeBonus
	{
		[Token(Token = "0x60067FA")]
		[Address(RVA = "0xBABDE0", Offset = "0xBAB1E0", VA = "0x180BABDE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60067FB")]
		[Address(RVA = "0xBAC340", Offset = "0xBAB740", VA = "0x180BAC340")]
		set
		{
		}
	}

	[Token(Token = "0x1700165E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAgeBonus
	{
		[Token(Token = "0x60067FC")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60067EF")]
	[Address(RVA = "0xBABC60", Offset = "0xBAB060", VA = "0x180BABC60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveElement()
	{
	}

	[Token(Token = "0x60067F0")]
	[Address(RVA = "0xBABD10", Offset = "0xBAB110", VA = "0x180BABD10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveElement(InteractiveElement other)
	{
	}

	[Token(Token = "0x60067F1")]
	[Address(RVA = "0xBAB420", Offset = "0xBAA820", VA = "0x180BAB420", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveElement Clone()
	{
		return null;
	}

	[Token(Token = "0x60067FD")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAgeBonus()
	{
	}

	[Token(Token = "0x60067FE")]
	[Address(RVA = "0xBAB620", Offset = "0xBAAA20", VA = "0x180BAB620", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60067FF")]
	[Address(RVA = "0xBAB520", Offset = "0xBAA920", VA = "0x180BAB520", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InteractiveElement other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006800")]
	[Address(RVA = "0xBAB760", Offset = "0xBAAB60", VA = "0x180BAB760", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006801")]
	[Address(RVA = "0xBAB9C0", Offset = "0xBAADC0", VA = "0x180BAB9C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006802")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006803")]
	[Address(RVA = "0xBAC140", Offset = "0xBAB540", VA = "0x180BAC140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006804")]
	[Address(RVA = "0xBAB260", Offset = "0xBAA660", VA = "0x180BAB260", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006805")]
	[Address(RVA = "0xBAB8F0", Offset = "0xBAACF0", VA = "0x180BAB8F0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(InteractiveElement other)
	{
	}

	[Token(Token = "0x6006806")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006807")]
	[Address(RVA = "0xBABF50", Offset = "0xBAB350", VA = "0x180BABF50", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
