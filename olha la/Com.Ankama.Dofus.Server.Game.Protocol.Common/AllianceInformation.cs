using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000994")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInformation : IMessage<AllianceInformation>, IMessage, IEquatable<AllianceInformation>, IDeepCloneable<AllianceInformation>, IBufferMessage
{
	[Token(Token = "0x2000995")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000996")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class AllianceCardInformation : IMessage<AllianceCardInformation>, IMessage, IEquatable<AllianceCardInformation>, IDeepCloneable<AllianceCardInformation>, IBufferMessage
		{
			[Token(Token = "0x400219E")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<AllianceCardInformation> _parser;

			[Token(Token = "0x400219F")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40021A0")]
			public const int CreationDateFieldNumber = 1;

			[Token(Token = "0x40021A1")]
			[FieldOffset(Offset = "0x18")]
			private long creationDate_;

			[Token(Token = "0x40021A2")]
			public const int MembersNumberFieldNumber = 2;

			[Token(Token = "0x40021A3")]
			[FieldOffset(Offset = "0x20")]
			private int membersNumber_;

			[Token(Token = "0x40021A4")]
			public const int SubareaNumberFieldNumber = 3;

			[Token(Token = "0x40021A5")]
			[FieldOffset(Offset = "0x24")]
			private int subareaNumber_;

			[Token(Token = "0x40021A6")]
			public const int TaxCollectorNumberFieldNumber = 4;

			[Token(Token = "0x40021A7")]
			[FieldOffset(Offset = "0x28")]
			private int taxCollectorNumber_;

			[Token(Token = "0x40021A8")]
			public const int RecruitmentFieldNumber = 5;

			[Token(Token = "0x40021A9")]
			[FieldOffset(Offset = "0x30")]
			private AllianceRecruitmentInformation recruitment_;

			[Token(Token = "0x17001544")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<AllianceCardInformation> Parser
			{
				[Token(Token = "0x60063E6")]
				[Address(RVA = "0xB8D6D0", Offset = "0xB8CAD0", VA = "0x180B8D6D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001545")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60063E7")]
				[Address(RVA = "0xB8D650", Offset = "0xB8CA50", VA = "0x180B8D650")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001546")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60063E8")]
				[Address(RVA = "0xB8D970", Offset = "0xB8CD70", VA = "0x180B8D970", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001547")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long CreationDate
			{
				[Token(Token = "0x60063EC")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60063ED")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17001548")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MembersNumber
			{
				[Token(Token = "0x60063EE")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60063EF")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17001549")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SubareaNumber
			{
				[Token(Token = "0x60063F0")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60063F1")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x1700154A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int TaxCollectorNumber
			{
				[Token(Token = "0x60063F2")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60063F3")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x1700154B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AllianceRecruitmentInformation Recruitment
			{
				[Token(Token = "0x60063F4")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60063F5")]
				[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
				set
				{
				}
			}

			[Token(Token = "0x60063E9")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AllianceCardInformation()
			{
			}

			[Token(Token = "0x60063EA")]
			[Address(RVA = "0xB8D5C0", Offset = "0xB8C9C0", VA = "0x180B8D5C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AllianceCardInformation(AllianceCardInformation other)
			{
			}

			[Token(Token = "0x60063EB")]
			[Address(RVA = "0xB8D060", Offset = "0xB8C460", VA = "0x180B8D060", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AllianceCardInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x60063F6")]
			[Address(RVA = "0xB8D1B0", Offset = "0xB8C5B0", VA = "0x180B8D1B0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60063F7")]
			[Address(RVA = "0xB8D120", Offset = "0xB8C520", VA = "0x180B8D120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(AllianceCardInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x60063F8")]
			[Address(RVA = "0xB8D280", Offset = "0xB8C680", VA = "0x180B8D280", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60063F9")]
			[Address(RVA = "0xB8D460", Offset = "0xB8C860", VA = "0x180B8D460", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60063FA")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60063FB")]
			[Address(RVA = "0xB8D890", Offset = "0xB8CC90", VA = "0x180B8D890", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60063FC")]
			[Address(RVA = "0xB8CF20", Offset = "0xB8C320", VA = "0x180B8CF20", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60063FD")]
			[Address(RVA = "0xB8D360", Offset = "0xB8C760", VA = "0x180B8D360", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(AllianceCardInformation other)
			{
			}

			[Token(Token = "0x60063FE")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60063FF")]
			[Address(RVA = "0xB8D720", Offset = "0xB8CB20", VA = "0x180B8D720", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002191")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInformation> _parser;

	[Token(Token = "0x4002192")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002193")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x4002194")]
	[FieldOffset(Offset = "0x18")]
	private string uid_;

	[Token(Token = "0x4002195")]
	public const int TagFieldNumber = 2;

	[Token(Token = "0x4002196")]
	[FieldOffset(Offset = "0x20")]
	private string tag_;

	[Token(Token = "0x4002197")]
	public const int NameFieldNumber = 3;

	[Token(Token = "0x4002198")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string NameDefaultValue;

	[Token(Token = "0x4002199")]
	[FieldOffset(Offset = "0x28")]
	private string name_;

	[Token(Token = "0x400219A")]
	public const int EmblemFieldNumber = 4;

	[Token(Token = "0x400219B")]
	[FieldOffset(Offset = "0x30")]
	private SocialEmblem emblem_;

	[Token(Token = "0x400219C")]
	public const int CardInformationFieldNumber = 5;

	[Token(Token = "0x400219D")]
	[FieldOffset(Offset = "0x38")]
	private Types.AllianceCardInformation cardInformation_;

	[Token(Token = "0x1700153B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceInformation> Parser
	{
		[Token(Token = "0x60063C9")]
		[Address(RVA = "0xB8E6C0", Offset = "0xB8DAC0", VA = "0x180B8E6C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700153C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60063CA")]
		[Address(RVA = "0xB8E5B0", Offset = "0xB8D9B0", VA = "0x180B8E5B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700153D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60063CB")]
		[Address(RVA = "0xB8EA70", Offset = "0xB8DE70", VA = "0x180B8EA70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700153E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Uid
	{
		[Token(Token = "0x60063CF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60063D0")]
		[Address(RVA = "0xB8EB90", Offset = "0xB8DF90", VA = "0x180B8EB90")]
		set
		{
		}
	}

	[Token(Token = "0x1700153F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Tag
	{
		[Token(Token = "0x60063D1")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60063D2")]
		[Address(RVA = "0xB8EB20", Offset = "0xB8DF20", VA = "0x180B8EB20")]
		set
		{
		}
	}

	[Token(Token = "0x17001540")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60063D3")]
		[Address(RVA = "0xB8E660", Offset = "0xB8DA60", VA = "0x180B8E660")]
		get
		{
			return null;
		}
		[Token(Token = "0x60063D4")]
		[Address(RVA = "0xB8EAB0", Offset = "0xB8DEB0", VA = "0x180B8EAB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001541")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasName
	{
		[Token(Token = "0x60063D5")]
		[Address(RVA = "0x916810", Offset = "0x915C10", VA = "0x180916810")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001542")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialEmblem Emblem
	{
		[Token(Token = "0x60063D7")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
		set
		{
		}
	}

	[Token(Token = "0x17001543")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.AllianceCardInformation CardInformation
	{
		[Token(Token = "0x60063D9")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60063DA")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x60063CC")]
	[Address(RVA = "0xB8E370", Offset = "0xB8D770", VA = "0x180B8E370")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInformation()
	{
	}

	[Token(Token = "0x60063CD")]
	[Address(RVA = "0xB8E3E0", Offset = "0xB8D7E0", VA = "0x180B8E3E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInformation(AllianceInformation other)
	{
	}

	[Token(Token = "0x60063CE")]
	[Address(RVA = "0xB8DBC0", Offset = "0xB8CFC0", VA = "0x180B8DBC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60063D6")]
	[Address(RVA = "0x916010", Offset = "0x915410", VA = "0x180916010")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearName()
	{
	}

	[Token(Token = "0x60063DB")]
	[Address(RVA = "0xB8DC20", Offset = "0xB8D020", VA = "0x180B8DC20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60063DC")]
	[Address(RVA = "0xB8DD40", Offset = "0xB8D140", VA = "0x180B8DD40", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60063DD")]
	[Address(RVA = "0xB8DE30", Offset = "0xB8D230", VA = "0x180B8DE30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60063DE")]
	[Address(RVA = "0xB8E1D0", Offset = "0xB8D5D0", VA = "0x180B8E1D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60063DF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60063E0")]
	[Address(RVA = "0xB8E920", Offset = "0xB8DD20", VA = "0x180B8E920", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60063E1")]
	[Address(RVA = "0xB8DA20", Offset = "0xB8CE20", VA = "0x180B8DA20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60063E2")]
	[Address(RVA = "0xB8DF80", Offset = "0xB8D380", VA = "0x180B8DF80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceInformation other)
	{
	}

	[Token(Token = "0x60063E3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60063E4")]
	[Address(RVA = "0xB8E710", Offset = "0xB8DB10", VA = "0x180B8E710", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
