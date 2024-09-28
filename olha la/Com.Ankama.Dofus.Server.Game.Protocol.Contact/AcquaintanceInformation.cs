using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x2000809")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AcquaintanceInformation : IMessage<AcquaintanceInformation>, IMessage, IEquatable<AcquaintanceInformation>, IDeepCloneable<AcquaintanceInformation>, IBufferMessage
{
	[Token(Token = "0x200080A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200080B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class OnlineInformation : IMessage<OnlineInformation>, IMessage, IEquatable<OnlineInformation>, IDeepCloneable<OnlineInformation>, IBufferMessage
		{
			[Token(Token = "0x4001BD6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<OnlineInformation> _parser;

			[Token(Token = "0x4001BD7")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001BD8")]
			public const int CharacterIdFieldNumber = 1;

			[Token(Token = "0x4001BD9")]
			[FieldOffset(Offset = "0x18")]
			private long characterId_;

			[Token(Token = "0x4001BDA")]
			public const int CharacterNameFieldNumber = 2;

			[Token(Token = "0x4001BDB")]
			[FieldOffset(Offset = "0x20")]
			private string characterName_;

			[Token(Token = "0x4001BDC")]
			public const int MoodSmileyIdFieldNumber = 3;

			[Token(Token = "0x4001BDD")]
			[FieldOffset(Offset = "0x28")]
			private int moodSmileyId_;

			[Token(Token = "0x4001BDE")]
			public const int StatusFieldNumber = 4;

			[Token(Token = "0x4001BDF")]
			[FieldOffset(Offset = "0x30")]
			private CharacterStatus status_;

			[Token(Token = "0x17001235")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<OnlineInformation> Parser
			{
				[Token(Token = "0x6005572")]
				[Address(RVA = "0xAF4170", Offset = "0xAF3570", VA = "0x180AF4170")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001236")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6005573")]
				[Address(RVA = "0xAF40F0", Offset = "0xAF34F0", VA = "0x180AF40F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001237")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6005574")]
				[Address(RVA = "0xAF4410", Offset = "0xAF3810", VA = "0x180AF4410", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001238")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long CharacterId
			{
				[Token(Token = "0x6005578")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6005579")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17001239")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string CharacterName
			{
				[Token(Token = "0x600557A")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x600557B")]
				[Address(RVA = "0xAF44C0", Offset = "0xAF38C0", VA = "0x180AF44C0")]
				set
				{
				}
			}

			[Token(Token = "0x1700123A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int MoodSmileyId
			{
				[Token(Token = "0x600557C")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600557D")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x1700123B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public CharacterStatus Status
			{
				[Token(Token = "0x600557E")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600557F")]
				[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
				set
				{
				}
			}

			[Token(Token = "0x6005575")]
			[Address(RVA = "0xAF40A0", Offset = "0xAF34A0", VA = "0x180AF40A0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public OnlineInformation()
			{
			}

			[Token(Token = "0x6005576")]
			[Address(RVA = "0xAF3FD0", Offset = "0xAF33D0", VA = "0x180AF3FD0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public OnlineInformation(OnlineInformation other)
			{
			}

			[Token(Token = "0x6005577")]
			[Address(RVA = "0xAF3A30", Offset = "0xAF2E30", VA = "0x180AF3A30", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public OnlineInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x6005580")]
			[Address(RVA = "0xAF3BC0", Offset = "0xAF2FC0", VA = "0x180AF3BC0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005581")]
			[Address(RVA = "0xAF3B30", Offset = "0xAF2F30", VA = "0x180AF3B30", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(OnlineInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005582")]
			[Address(RVA = "0xAF3CA0", Offset = "0xAF30A0", VA = "0x180AF3CA0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6005583")]
			[Address(RVA = "0xAF3E70", Offset = "0xAF3270", VA = "0x180AF3E70", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6005584")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6005585")]
			[Address(RVA = "0xAF4340", Offset = "0xAF3740", VA = "0x180AF4340", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6005586")]
			[Address(RVA = "0xAF3920", Offset = "0xAF2D20", VA = "0x180AF3920", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6005587")]
			[Address(RVA = "0xAF3D70", Offset = "0xAF3170", VA = "0x180AF3D70", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(OnlineInformation other)
			{
			}

			[Token(Token = "0x6005588")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6005589")]
			[Address(RVA = "0xAF41C0", Offset = "0xAF35C0", VA = "0x180AF41C0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001BCC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AcquaintanceInformation> _parser;

	[Token(Token = "0x4001BCD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001BCE")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4001BCF")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x4001BD0")]
	public const int AccountTagFieldNumber = 2;

	[Token(Token = "0x4001BD1")]
	[FieldOffset(Offset = "0x20")]
	private AccountTag accountTag_;

	[Token(Token = "0x4001BD2")]
	public const int StateFieldNumber = 3;

	[Token(Token = "0x4001BD3")]
	[FieldOffset(Offset = "0x28")]
	private CharacterState state_;

	[Token(Token = "0x4001BD4")]
	public const int OnlineFieldNumber = 4;

	[Token(Token = "0x4001BD5")]
	[FieldOffset(Offset = "0x30")]
	private Types.OnlineInformation online_;

	[Token(Token = "0x1700122E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AcquaintanceInformation> Parser
	{
		[Token(Token = "0x6005559")]
		[Address(RVA = "0xAE49C0", Offset = "0xAE3DC0", VA = "0x180AE49C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700122F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600555A")]
		[Address(RVA = "0xAE4910", Offset = "0xAE3D10", VA = "0x180AE4910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001230")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600555B")]
		[Address(RVA = "0xAE4C60", Offset = "0xAE4060", VA = "0x180AE4C60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001231")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x600555F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001232")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccountTag AccountTag
	{
		[Token(Token = "0x6005561")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17001233")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterState State
	{
		[Token(Token = "0x6005563")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(CharacterState);
		}
		[Token(Token = "0x6005564")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001234")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.OnlineInformation Online
	{
		[Token(Token = "0x6005565")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005566")]
		[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
		set
		{
		}
	}

	[Token(Token = "0x600555C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AcquaintanceInformation()
	{
	}

	[Token(Token = "0x600555D")]
	[Address(RVA = "0xAE4780", Offset = "0xAE3B80", VA = "0x180AE4780")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AcquaintanceInformation(AcquaintanceInformation other)
	{
	}

	[Token(Token = "0x600555E")]
	[Address(RVA = "0xAE4010", Offset = "0xAE3410", VA = "0x180AE4010", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AcquaintanceInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6005567")]
	[Address(RVA = "0xAE4260", Offset = "0xAE3660", VA = "0x180AE4260", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005568")]
	[Address(RVA = "0xAE41D0", Offset = "0xAE35D0", VA = "0x180AE41D0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AcquaintanceInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005569")]
	[Address(RVA = "0xAE4340", Offset = "0xAE3740", VA = "0x180AE4340", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600556A")]
	[Address(RVA = "0xAE4620", Offset = "0xAE3A20", VA = "0x180AE4620", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600556B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600556C")]
	[Address(RVA = "0xAE4BA0", Offset = "0xAE3FA0", VA = "0x180AE4BA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600556D")]
	[Address(RVA = "0xAE3F00", Offset = "0xAE3300", VA = "0x180AE3F00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600556E")]
	[Address(RVA = "0xAE4410", Offset = "0xAE3810", VA = "0x180AE4410", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AcquaintanceInformation other)
	{
	}

	[Token(Token = "0x600556F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005570")]
	[Address(RVA = "0xAE4A10", Offset = "0xAE3E10", VA = "0x180AE4A10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
