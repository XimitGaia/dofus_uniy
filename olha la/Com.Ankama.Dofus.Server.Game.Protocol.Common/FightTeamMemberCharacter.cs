using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A2F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamMemberCharacter : IMessage<FightTeamMemberCharacter>, IMessage, IEquatable<FightTeamMemberCharacter>, IDeepCloneable<FightTeamMemberCharacter>, IBufferMessage
{
	[Token(Token = "0x2000A30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000A31")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class BasicAllianceInformation : IMessage<BasicAllianceInformation>, IMessage, IEquatable<BasicAllianceInformation>, IDeepCloneable<BasicAllianceInformation>, IBufferMessage
		{
			[Token(Token = "0x40024B4")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<BasicAllianceInformation> _parser;

			[Token(Token = "0x40024B5")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40024B6")]
			public const int AllianceUidFieldNumber = 1;

			[Token(Token = "0x40024B7")]
			[FieldOffset(Offset = "0x18")]
			private string allianceUid_;

			[Token(Token = "0x40024B8")]
			public const int AllianceTagFieldNumber = 2;

			[Token(Token = "0x40024B9")]
			[FieldOffset(Offset = "0x20")]
			private string allianceTag_;

			[Token(Token = "0x17001702")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<BasicAllianceInformation> Parser
			{
				[Token(Token = "0x6006A86")]
				[Address(RVA = "0xBB3D90", Offset = "0xBB3190", VA = "0x180BB3D90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001703")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006A87")]
				[Address(RVA = "0xBB3D10", Offset = "0xBB3110", VA = "0x180BB3D10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001704")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006A88")]
				[Address(RVA = "0xBB3ED0", Offset = "0xBB32D0", VA = "0x180BB3ED0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001705")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string AllianceUid
			{
				[Token(Token = "0x6006A8C")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006A8D")]
				[Address(RVA = "0xBB3FF0", Offset = "0xBB33F0", VA = "0x180BB3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17001706")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string AllianceTag
			{
				[Token(Token = "0x6006A8E")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006A8F")]
				[Address(RVA = "0xBB3F80", Offset = "0xBB3380", VA = "0x180BB3F80")]
				set
				{
				}
			}

			[Token(Token = "0x6006A89")]
			[Address(RVA = "0xBB3CA0", Offset = "0xBB30A0", VA = "0x180BB3CA0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public BasicAllianceInformation()
			{
			}

			[Token(Token = "0x6006A8A")]
			[Address(RVA = "0xBB3BC0", Offset = "0xBB2FC0", VA = "0x180BB3BC0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public BasicAllianceInformation(BasicAllianceInformation other)
			{
			}

			[Token(Token = "0x6006A8B")]
			[Address(RVA = "0xBB3820", Offset = "0xBB2C20", VA = "0x180BB3820", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public BasicAllianceInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x6006A90")]
			[Address(RVA = "0xBB3920", Offset = "0xBB2D20", VA = "0x180BB3920", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006A91")]
			[Address(RVA = "0x931D60", Offset = "0x931160", VA = "0x180931D60", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(BasicAllianceInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006A92")]
			[Address(RVA = "0x931DE0", Offset = "0x9311E0", VA = "0x180931DE0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006A93")]
			[Address(RVA = "0xBB3A60", Offset = "0xBB2E60", VA = "0x180BB3A60", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006A94")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006A95")]
			[Address(RVA = "0x932390", Offset = "0x931790", VA = "0x180932390", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006A96")]
			[Address(RVA = "0xBB3760", Offset = "0xBB2B60", VA = "0x180BB3760", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006A97")]
			[Address(RVA = "0xBB39E0", Offset = "0xBB2DE0", VA = "0x180BB39E0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(BasicAllianceInformation other)
			{
			}

			[Token(Token = "0x6006A98")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006A99")]
			[Address(RVA = "0xBB3DE0", Offset = "0xBB31E0", VA = "0x180BB3DE0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40024AC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamMemberCharacter> _parser;

	[Token(Token = "0x40024AD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40024AE")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x40024AF")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x40024B0")]
	public const int LevelFieldNumber = 2;

	[Token(Token = "0x40024B1")]
	[FieldOffset(Offset = "0x20")]
	private int level_;

	[Token(Token = "0x40024B2")]
	public const int AllianceInfoFieldNumber = 3;

	[Token(Token = "0x40024B3")]
	[FieldOffset(Offset = "0x28")]
	private Types.BasicAllianceInformation allianceInfo_;

	[Token(Token = "0x170016FC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTeamMemberCharacter> Parser
	{
		[Token(Token = "0x6006A6F")]
		[Address(RVA = "0xBBC790", Offset = "0xBBBB90", VA = "0x180BBC790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006A70")]
		[Address(RVA = "0xBBC6E0", Offset = "0xBBBAE0", VA = "0x180BBC6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016FE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006A71")]
		[Address(RVA = "0xBBC9F0", Offset = "0xBBBDF0", VA = "0x180BBC9F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x6006A75")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A76")]
		[Address(RVA = "0xBBCA30", Offset = "0xBBBE30", VA = "0x180BBCA30")]
		set
		{
		}
	}

	[Token(Token = "0x17001700")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		[Token(Token = "0x6006A77")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006A78")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001701")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.BasicAllianceInformation AllianceInfo
	{
		[Token(Token = "0x6006A79")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A7A")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6006A72")]
	[Address(RVA = "0xBBC4F0", Offset = "0xBBB8F0", VA = "0x180BBC4F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberCharacter()
	{
	}

	[Token(Token = "0x6006A73")]
	[Address(RVA = "0xBBC540", Offset = "0xBBB940", VA = "0x180BBC540")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberCharacter(FightTeamMemberCharacter other)
	{
	}

	[Token(Token = "0x6006A74")]
	[Address(RVA = "0xBBBE70", Offset = "0xBBB270", VA = "0x180BBBE70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberCharacter Clone()
	{
		return null;
	}

	[Token(Token = "0x6006A7B")]
	[Address(RVA = "0xBBC0C0", Offset = "0xBBB4C0", VA = "0x180BBC0C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A7C")]
	[Address(RVA = "0xBBC040", Offset = "0xBBB440", VA = "0x180BBC040", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTeamMemberCharacter other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A7D")]
	[Address(RVA = "0xBBC190", Offset = "0xBBB590", VA = "0x180BBC190", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006A7E")]
	[Address(RVA = "0xBBC390", Offset = "0xBBB790", VA = "0x180BBC390", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006A7F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006A80")]
	[Address(RVA = "0xBBC940", Offset = "0xBBBD40", VA = "0x180BBC940", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006A81")]
	[Address(RVA = "0xBBBD80", Offset = "0xBBB180", VA = "0x180BBBD80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006A82")]
	[Address(RVA = "0xBBC240", Offset = "0xBBB640", VA = "0x180BBC240", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTeamMemberCharacter other)
	{
	}

	[Token(Token = "0x6006A83")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006A84")]
	[Address(RVA = "0xBBC7E0", Offset = "0xBBBBE0", VA = "0x180BBC7E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
