using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debt;

[Token(Token = "0x2000776")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DebtsUpdateEvent : IMessage<DebtsUpdateEvent>, IMessage, IEquatable<DebtsUpdateEvent>, IDeepCloneable<DebtsUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x2000777")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000778")]
		public enum DebtsAction
		{
			[Token(Token = "0x4001A1E")]
			[OriginalName("DISPATCH")]
			Dispatch,
			[Token(Token = "0x4001A1F")]
			[OriginalName("UPDATE")]
			Update
		}

		[Token(Token = "0x2000779")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class DebtInformation : IMessage<DebtInformation>, IMessage, IEquatable<DebtInformation>, IDeepCloneable<DebtInformation>, IBufferMessage
		{
			[Token(Token = "0x4001A20")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<DebtInformation> _parser;

			[Token(Token = "0x4001A21")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001A22")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4001A23")]
			public const int DebtIdFieldNumber = 1;

			[Token(Token = "0x4001A24")]
			[FieldOffset(Offset = "0x20")]
			private long debtId_;

			[Token(Token = "0x4001A25")]
			public const int TimestampFieldNumber = 2;

			[Token(Token = "0x4001A26")]
			[FieldOffset(Offset = "0x28")]
			private long timestamp_;

			[Token(Token = "0x4001A27")]
			public const int KamasFieldNumber = 3;

			[Token(Token = "0x4001A28")]
			[FieldOffset(Offset = "0x8")]
			private static readonly long KamasDefaultValue;

			[Token(Token = "0x4001A29")]
			[FieldOffset(Offset = "0x30")]
			private long kamas_;

			[Token(Token = "0x1700110C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<DebtInformation> Parser
			{
				[Token(Token = "0x6004FB6")]
				[Address(RVA = "0xAD5A80", Offset = "0xAD4E80", VA = "0x180AD5A80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700110D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6004FB7")]
				[Address(RVA = "0xAD5990", Offset = "0xAD4D90", VA = "0x180AD5990")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700110E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6004FB8")]
				[Address(RVA = "0xAD5C90", Offset = "0xAD5090", VA = "0x180AD5C90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700110F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long DebtId
			{
				[Token(Token = "0x6004FBC")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6004FBD")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001110")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long Timestamp
			{
				[Token(Token = "0x6004FBE")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6004FBF")]
				[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
				set
				{
				}
			}

			[Token(Token = "0x17001111")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long Kamas
			{
				[Token(Token = "0x6004FC0")]
				[Address(RVA = "0xAD5A10", Offset = "0xAD4E10", VA = "0x180AD5A10")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6004FC1")]
				[Address(RVA = "0xAD5D40", Offset = "0xAD5140", VA = "0x180AD5D40")]
				set
				{
				}
			}

			[Token(Token = "0x17001112")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasKamas
			{
				[Token(Token = "0x6004FC2")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6004FB9")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DebtInformation()
			{
			}

			[Token(Token = "0x6004FBA")]
			[Address(RVA = "0xAD5920", Offset = "0xAD4D20", VA = "0x180AD5920")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DebtInformation(DebtInformation other)
			{
			}

			[Token(Token = "0x6004FBB")]
			[Address(RVA = "0xAD5430", Offset = "0xAD4830", VA = "0x180AD5430", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DebtInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x6004FC3")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearKamas()
			{
			}

			[Token(Token = "0x6004FC4")]
			[Address(RVA = "0xAD54D0", Offset = "0xAD48D0", VA = "0x180AD54D0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004FC5")]
			[Address(RVA = "0xAD55A0", Offset = "0xAD49A0", VA = "0x180AD55A0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(DebtInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004FC6")]
			[Address(RVA = "0xAD5630", Offset = "0xAD4A30", VA = "0x180AD5630", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6004FC7")]
			[Address(RVA = "0xAD57B0", Offset = "0xAD4BB0", VA = "0x180AD57B0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6004FC8")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6004FC9")]
			[Address(RVA = "0xAD5BA0", Offset = "0xAD4FA0", VA = "0x180AD5BA0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6004FCA")]
			[Address(RVA = "0xAD52F0", Offset = "0xAD46F0", VA = "0x180AD52F0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6004FCB")]
			[Address(RVA = "0xAD5730", Offset = "0xAD4B30", VA = "0x180AD5730", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(DebtInformation other)
			{
			}

			[Token(Token = "0x6004FCC")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004FCD")]
			[Address(RVA = "0xAD5AD0", Offset = "0xAD4ED0", VA = "0x180AD5AD0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001A16")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DebtsUpdateEvent> _parser;

	[Token(Token = "0x4001A17")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A18")]
	public const int ActionFieldNumber = 1;

	[Token(Token = "0x4001A19")]
	[FieldOffset(Offset = "0x18")]
	private Types.DebtsAction action_;

	[Token(Token = "0x4001A1A")]
	public const int DebtsFieldNumber = 2;

	[Token(Token = "0x4001A1B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.DebtInformation> _repeated_debts_codec;

	[Token(Token = "0x4001A1C")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.DebtInformation> debts_;

	[Token(Token = "0x17001107")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DebtsUpdateEvent> Parser
	{
		[Token(Token = "0x6004FA2")]
		[Address(RVA = "0xAD78F0", Offset = "0xAD6CF0", VA = "0x180AD78F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001108")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004FA3")]
		[Address(RVA = "0xAD7840", Offset = "0xAD6C40", VA = "0x180AD7840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001109")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0xAD7B40", Offset = "0xAD6F40", VA = "0x180AD7B40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.DebtsAction Action
	{
		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.DebtsAction);
		}
		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700110B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.DebtInformation> Debts
	{
		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004FA5")]
	[Address(RVA = "0xAD7730", Offset = "0xAD6B30", VA = "0x180AD7730")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebtsUpdateEvent()
	{
	}

	[Token(Token = "0x6004FA6")]
	[Address(RVA = "0xAD77B0", Offset = "0xAD6BB0", VA = "0x180AD77B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebtsUpdateEvent(DebtsUpdateEvent other)
	{
	}

	[Token(Token = "0x6004FA7")]
	[Address(RVA = "0xAD7260", Offset = "0xAD6660", VA = "0x180AD7260", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebtsUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004FAB")]
	[Address(RVA = "0xAD7320", Offset = "0xAD6720", VA = "0x180AD7320", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FAC")]
	[Address(RVA = "0xAD7400", Offset = "0xAD6800", VA = "0x180AD7400", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DebtsUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FAD")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004FAE")]
	[Address(RVA = "0xAD7530", Offset = "0xAD6930", VA = "0x180AD7530", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004FAF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004FB0")]
	[Address(RVA = "0xAD7A70", Offset = "0xAD6E70", VA = "0x180AD7A70", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004FB1")]
	[Address(RVA = "0xAD7180", Offset = "0xAD6580", VA = "0x180AD7180", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004FB2")]
	[Address(RVA = "0xAD74A0", Offset = "0xAD68A0", VA = "0x180AD74A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DebtsUpdateEvent other)
	{
	}

	[Token(Token = "0x6004FB3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004FB4")]
	[Address(RVA = "0xAD7940", Offset = "0xAD6D40", VA = "0x180AD7940", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
