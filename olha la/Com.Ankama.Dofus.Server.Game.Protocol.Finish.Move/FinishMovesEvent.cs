using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Finish.Move;

[Token(Token = "0x20005D9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishMovesEvent : IMessage<FinishMovesEvent>, IMessage, IEquatable<FinishMovesEvent>, IDeepCloneable<FinishMovesEvent>, IBufferMessage
{
	[Token(Token = "0x20005DA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20005DB")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class FinishMove : IMessage<FinishMove>, IMessage, IEquatable<FinishMove>, IDeepCloneable<FinishMove>, IBufferMessage
		{
			[Token(Token = "0x400146A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<FinishMove> _parser;

			[Token(Token = "0x400146B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400146C")]
			public const int FinishMoveIdFieldNumber = 1;

			[Token(Token = "0x400146D")]
			[FieldOffset(Offset = "0x18")]
			private int finishMoveId_;

			[Token(Token = "0x400146E")]
			public const int EffectiveFieldNumber = 2;

			[Token(Token = "0x400146F")]
			[FieldOffset(Offset = "0x1C")]
			private bool effective_;

			[Token(Token = "0x17000D64")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<FinishMove> Parser
			{
				[Token(Token = "0x6003E77")]
				[Address(RVA = "0xA4FEF0", Offset = "0xA4F2F0", VA = "0x180A4FEF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D65")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003E78")]
				[Address(RVA = "0xA4FE70", Offset = "0xA4F270", VA = "0x180A4FE70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D66")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003E79")]
				[Address(RVA = "0xA4FF40", Offset = "0xA4F340", VA = "0x180A4FF40", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D67")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int FinishMoveId
			{
				[Token(Token = "0x6003E7D")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003E7E")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000D68")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Effective
			{
				[Token(Token = "0x6003E7F")]
				[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003E80")]
				[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
				set
				{
				}
			}

			[Token(Token = "0x6003E7A")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FinishMove()
			{
			}

			[Token(Token = "0x6003E7B")]
			[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FinishMove(FinishMove other)
			{
			}

			[Token(Token = "0x6003E7C")]
			[Address(RVA = "0xA4FB30", Offset = "0xA4EF30", VA = "0x180A4FB30", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FinishMove Clone()
			{
				return null;
			}

			[Token(Token = "0x6003E81")]
			[Address(RVA = "0xA4FBC0", Offset = "0xA4EFC0", VA = "0x180A4FBC0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003E82")]
			[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(FinishMove other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003E83")]
			[Address(RVA = "0xA4FC50", Offset = "0xA4F050", VA = "0x180A4FC50", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003E84")]
			[Address(RVA = "0xA4FD10", Offset = "0xA4F110", VA = "0x180A4FD10", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003E85")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003E86")]
			[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003E87")]
			[Address(RVA = "0xA4FAA0", Offset = "0xA4EEA0", VA = "0x180A4FAA0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003E88")]
			[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(FinishMove other)
			{
			}

			[Token(Token = "0x6003E89")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003E8A")]
			[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FinishMovesEvent> _parser;

	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001467")]
	public const int FinishMovesFieldNumber = 1;

	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.FinishMove> _repeated_finishMoves_codec;

	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.FinishMove> finishMoves_;

	[Token(Token = "0x17000D60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishMovesEvent> Parser
	{
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0xA50700", Offset = "0xA4FB00", VA = "0x180A50700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D61")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0xA50650", Offset = "0xA4FA50", VA = "0x180A50650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D62")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0xA50910", Offset = "0xA4FD10", VA = "0x180A50910", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D63")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.FinishMove> FinishMoves
	{
		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E68")]
	[Address(RVA = "0xA505D0", Offset = "0xA4F9D0", VA = "0x180A505D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMovesEvent()
	{
	}

	[Token(Token = "0x6003E69")]
	[Address(RVA = "0xA50540", Offset = "0xA4F940", VA = "0x180A50540")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMovesEvent(FinishMovesEvent other)
	{
	}

	[Token(Token = "0x6003E6A")]
	[Address(RVA = "0xA50090", Offset = "0xA4F490", VA = "0x180A50090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMovesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003E6C")]
	[Address(RVA = "0xA501E0", Offset = "0xA4F5E0", VA = "0x180A501E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E6D")]
	[Address(RVA = "0xA50150", Offset = "0xA4F550", VA = "0x180A50150", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FinishMovesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0xA50340", Offset = "0xA4F740", VA = "0x180A50340", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003E70")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003E71")]
	[Address(RVA = "0xA50860", Offset = "0xA4FC60", VA = "0x180A50860", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003E72")]
	[Address(RVA = "0xA4FFF0", Offset = "0xA4F3F0", VA = "0x180A4FFF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003E73")]
	[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", VA = "0x180A502C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishMovesEvent other)
	{
	}

	[Token(Token = "0x6003E74")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003E75")]
	[Address(RVA = "0xA50750", Offset = "0xA4FB50", VA = "0x180A50750", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
