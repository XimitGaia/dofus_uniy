using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009F1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlignmentInformation : IMessage<AlignmentInformation>, IMessage, IEquatable<AlignmentInformation>, IDeepCloneable<AlignmentInformation>, IBufferMessage
{
	[Token(Token = "0x20009F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20009F3")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class AlignmentExtendedInformation : IMessage<AlignmentExtendedInformation>, IMessage, IEquatable<AlignmentExtendedInformation>, IDeepCloneable<AlignmentExtendedInformation>, IBufferMessage
		{
			[Token(Token = "0x4002377")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<AlignmentExtendedInformation> _parser;

			[Token(Token = "0x4002378")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002379")]
			public const int HonorFieldNumber = 1;

			[Token(Token = "0x400237A")]
			[FieldOffset(Offset = "0x18")]
			private int honor_;

			[Token(Token = "0x400237B")]
			public const int HonorGradeFloorFieldNumber = 2;

			[Token(Token = "0x400237C")]
			[FieldOffset(Offset = "0x1C")]
			private int honorGradeFloor_;

			[Token(Token = "0x400237D")]
			public const int HonorNextGradeFloorFieldNumber = 3;

			[Token(Token = "0x400237E")]
			[FieldOffset(Offset = "0x20")]
			private int honorNextGradeFloor_;

			[Token(Token = "0x400237F")]
			public const int AttackableFieldNumber = 4;

			[Token(Token = "0x4002380")]
			[FieldOffset(Offset = "0x24")]
			private AttackableStatus attackable_;

			[Token(Token = "0x1700164E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<AlignmentExtendedInformation> Parser
			{
				[Token(Token = "0x60067CD")]
				[Address(RVA = "0xBA11D0", Offset = "0xBA05D0", VA = "0x180BA11D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700164F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60067CE")]
				[Address(RVA = "0xBA1150", Offset = "0xBA0550", VA = "0x180BA1150")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001650")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60067CF")]
				[Address(RVA = "0xBA13E0", Offset = "0xBA07E0", VA = "0x180BA13E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001651")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Honor
			{
				[Token(Token = "0x60067D3")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60067D4")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17001652")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int HonorGradeFloor
			{
				[Token(Token = "0x60067D5")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60067D6")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001653")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int HonorNextGradeFloor
			{
				[Token(Token = "0x60067D7")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60067D8")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17001654")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AttackableStatus Attackable
			{
				[Token(Token = "0x60067D9")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(AttackableStatus);
				}
				[Token(Token = "0x60067DA")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x60067D0")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AlignmentExtendedInformation()
			{
			}

			[Token(Token = "0x60067D1")]
			[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AlignmentExtendedInformation(AlignmentExtendedInformation other)
			{
			}

			[Token(Token = "0x60067D2")]
			[Address(RVA = "0xBA0D50", Offset = "0xBA0150", VA = "0x180BA0D50", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AlignmentExtendedInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x60067DB")]
			[Address(RVA = "0xBA0DE0", Offset = "0xBA01E0", VA = "0x180BA0DE0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60067DC")]
			[Address(RVA = "0xBA0E80", Offset = "0xBA0280", VA = "0x180BA0E80", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(AlignmentExtendedInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x60067DD")]
			[Address(RVA = "0xBA0EC0", Offset = "0xBA02C0", VA = "0x180BA0EC0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60067DE")]
			[Address(RVA = "0xBA0FF0", Offset = "0xBA03F0", VA = "0x180BA0FF0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60067DF")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60067E0")]
			[Address(RVA = "0xBA1320", Offset = "0xBA0720", VA = "0x180BA1320", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60067E1")]
			[Address(RVA = "0xBA0C40", Offset = "0xBA0040", VA = "0x180BA0C40", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60067E2")]
			[Address(RVA = "0xBA0F80", Offset = "0xBA0380", VA = "0x180BA0F80", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(AlignmentExtendedInformation other)
			{
			}

			[Token(Token = "0x60067E3")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60067E4")]
			[Address(RVA = "0xBA1220", Offset = "0xBA0620", VA = "0x180BA1220", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002369")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlignmentInformation> _parser;

	[Token(Token = "0x400236A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400236B")]
	public const int AlignmentFieldNumber = 1;

	[Token(Token = "0x400236C")]
	[FieldOffset(Offset = "0x18")]
	private Alignment alignment_;

	[Token(Token = "0x400236D")]
	public const int AlignmentQuestNumberFieldNumber = 2;

	[Token(Token = "0x400236E")]
	[FieldOffset(Offset = "0x1C")]
	private int alignmentQuestNumber_;

	[Token(Token = "0x400236F")]
	public const int AlignmentGradeFieldNumber = 3;

	[Token(Token = "0x4002370")]
	[FieldOffset(Offset = "0x20")]
	private int alignmentGrade_;

	[Token(Token = "0x4002371")]
	public const int CharacterIdFieldNumber = 4;

	[Token(Token = "0x4002372")]
	[FieldOffset(Offset = "0x28")]
	private long characterId_;

	[Token(Token = "0x4002373")]
	public const int CharacterLevelFieldNumber = 5;

	[Token(Token = "0x4002374")]
	[FieldOffset(Offset = "0x30")]
	private long characterLevel_;

	[Token(Token = "0x4002375")]
	public const int ExtendedInformationFieldNumber = 6;

	[Token(Token = "0x4002376")]
	[FieldOffset(Offset = "0x38")]
	private Types.AlignmentExtendedInformation extendedInformation_;

	[Token(Token = "0x17001645")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AlignmentInformation> Parser
	{
		[Token(Token = "0x60067B0")]
		[Address(RVA = "0xBA1E20", Offset = "0xBA1220", VA = "0x180BA1E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001646")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60067B1")]
		[Address(RVA = "0xBA1D70", Offset = "0xBA1170", VA = "0x180BA1D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001647")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60067B2")]
		[Address(RVA = "0xBA2100", Offset = "0xBA1500", VA = "0x180BA2100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001648")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alignment Alignment
	{
		[Token(Token = "0x60067B6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Alignment);
		}
		[Token(Token = "0x60067B7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001649")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AlignmentQuestNumber
	{
		[Token(Token = "0x60067B8")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60067B9")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700164A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AlignmentGrade
	{
		[Token(Token = "0x60067BA")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60067BB")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700164B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x60067BC")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60067BD")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x1700164C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterLevel
	{
		[Token(Token = "0x60067BE")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60067BF")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700164D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.AlignmentExtendedInformation ExtendedInformation
	{
		[Token(Token = "0x60067C0")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60067C1")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x60067B3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlignmentInformation()
	{
	}

	[Token(Token = "0x60067B4")]
	[Address(RVA = "0xBA1C60", Offset = "0xBA1060", VA = "0x180BA1C60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlignmentInformation(AlignmentInformation other)
	{
	}

	[Token(Token = "0x60067B5")]
	[Address(RVA = "0xBA1600", Offset = "0xBA0A00", VA = "0x180BA1600", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlignmentInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60067C2")]
	[Address(RVA = "0xBA17D0", Offset = "0xBA0BD0", VA = "0x180BA17D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60067C3")]
	[Address(RVA = "0xBA1740", Offset = "0xBA0B40", VA = "0x180BA1740", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlignmentInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60067C4")]
	[Address(RVA = "0xBA18B0", Offset = "0xBA0CB0", VA = "0x180BA18B0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60067C5")]
	[Address(RVA = "0xBA1B00", Offset = "0xBA0F00", VA = "0x180BA1B00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60067C6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60067C7")]
	[Address(RVA = "0xBA2000", Offset = "0xBA1400", VA = "0x180BA2000", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60067C8")]
	[Address(RVA = "0xBA1490", Offset = "0xBA0890", VA = "0x180BA1490", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60067C9")]
	[Address(RVA = "0xBA19B0", Offset = "0xBA0DB0", VA = "0x180BA19B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlignmentInformation other)
	{
	}

	[Token(Token = "0x60067CA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60067CB")]
	[Address(RVA = "0xBA1E70", Offset = "0xBA1270", VA = "0x180BA1E70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
