using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x20001A8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestActive : IMessage<QuestActive>, IMessage, IEquatable<QuestActive>, IDeepCloneable<QuestActive>, IBufferMessage
{
	[Token(Token = "0x20001A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20001AA")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Details : IMessage<Details>, IMessage, IEquatable<Details>, IDeepCloneable<Details>, IBufferMessage
		{
			[Token(Token = "0x40005A4")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Details> _parser;

			[Token(Token = "0x40005A5")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40005A6")]
			public const int StepIdFieldNumber = 1;

			[Token(Token = "0x40005A7")]
			[FieldOffset(Offset = "0x18")]
			private int stepId_;

			[Token(Token = "0x40005A8")]
			public const int ObjectivesFieldNumber = 2;

			[Token(Token = "0x40005A9")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<QuestObjective> _repeated_objectives_codec;

			[Token(Token = "0x40005AA")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<QuestObjective> objectives_;

			[Token(Token = "0x1700039B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Details> Parser
			{
				[Token(Token = "0x60010E9")]
				[Address(RVA = "0xCC15E0", Offset = "0xCC09E0", VA = "0x180CC15E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700039C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60010EA")]
				[Address(RVA = "0xCC1560", Offset = "0xCC0960", VA = "0x180CC1560")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700039D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60010EB")]
				[Address(RVA = "0xCC1830", Offset = "0xCC0C30", VA = "0x180CC1830", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700039E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int StepId
			{
				[Token(Token = "0x60010EF")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60010F0")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x1700039F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<QuestObjective> Objectives
			{
				[Token(Token = "0x60010F1")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60010EC")]
			[Address(RVA = "0xCC1450", Offset = "0xCC0850", VA = "0x180CC1450")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Details()
			{
			}

			[Token(Token = "0x60010ED")]
			[Address(RVA = "0xCC14D0", Offset = "0xCC08D0", VA = "0x180CC14D0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Details(Details other)
			{
			}

			[Token(Token = "0x60010EE")]
			[Address(RVA = "0xCC0F80", Offset = "0xCC0380", VA = "0x180CC0F80", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Details Clone()
			{
				return null;
			}

			[Token(Token = "0x60010F2")]
			[Address(RVA = "0xCC1040", Offset = "0xCC0440", VA = "0x180CC1040", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60010F3")]
			[Address(RVA = "0xCC1120", Offset = "0xCC0520", VA = "0x180CC1120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Details other)
			{
				return default(bool);
			}

			[Token(Token = "0x60010F4")]
			[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60010F5")]
			[Address(RVA = "0xCC1250", Offset = "0xCC0650", VA = "0x180CC1250", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60010F6")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60010F7")]
			[Address(RVA = "0xCC1760", Offset = "0xCC0B60", VA = "0x180CC1760", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60010F8")]
			[Address(RVA = "0xCC0EA0", Offset = "0xCC02A0", VA = "0x180CC0EA0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60010F9")]
			[Address(RVA = "0xCC11C0", Offset = "0xCC05C0", VA = "0x180CC11C0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Details other)
			{
			}

			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60010FB")]
			[Address(RVA = "0xCC1630", Offset = "0xCC0A30", VA = "0x180CC1630", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestActive> _parser;

	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005A0")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x40005A2")]
	public const int DetailsFieldNumber = 2;

	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x20")]
	private Types.Details details_;

	[Token(Token = "0x17000396")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestActive> Parser
	{
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0xCD2C30", Offset = "0xCD2030", VA = "0x180CD2C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000397")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0xCD2B80", Offset = "0xCD1F80", VA = "0x180CD2B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000398")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0xCD2DA0", Offset = "0xCD21A0", VA = "0x180CD2DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000399")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestId
	{
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700039A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Details Details
	{
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestActive()
	{
	}

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0xCD2A60", Offset = "0xCD1E60", VA = "0x180CD2A60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestActive(QuestActive other)
	{
	}

	[Token(Token = "0x60010D9")]
	[Address(RVA = "0xCD25C0", Offset = "0xCD19C0", VA = "0x180CD25C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestActive Clone()
	{
		return null;
	}

	[Token(Token = "0x60010DE")]
	[Address(RVA = "0xCD2710", Offset = "0xCD1B10", VA = "0x180CD2710", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestActive other)
	{
		return default(bool);
	}

	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60010E1")]
	[Address(RVA = "0xCD2900", Offset = "0xCD1D00", VA = "0x180CD2900", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60010E4")]
	[Address(RVA = "0xCD2500", Offset = "0xCD1900", VA = "0x180CD2500", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60010E5")]
	[Address(RVA = "0xCD27C0", Offset = "0xCD1BC0", VA = "0x180CD27C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestActive other)
	{
	}

	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60010E7")]
	[Address(RVA = "0xCD2C80", Offset = "0xCD2080", VA = "0x180CD2C80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
