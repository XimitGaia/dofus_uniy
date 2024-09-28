using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007EC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BlockEvent : IMessage<BlockEvent>, IMessage, IEquatable<BlockEvent>, IDeepCloneable<BlockEvent>, IBufferMessage
{
	[Token(Token = "0x20007ED")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x4001B62")]
		None,
		[Token(Token = "0x4001B63")]
		Error,
		[Token(Token = "0x4001B64")]
		Success
	}

	[Token(Token = "0x20007EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20007EF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Error : IMessage<Error>, IMessage, IEquatable<Error>, IDeepCloneable<Error>, IBufferMessage
		{
			[Token(Token = "0x4001B65")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Error> _parser;

			[Token(Token = "0x4001B66")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001B67")]
			public const int ReasonFieldNumber = 1;

			[Token(Token = "0x4001B68")]
			[FieldOffset(Offset = "0x18")]
			private AddFailureReason reason_;

			[Token(Token = "0x170011EB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Error> Parser
			{
				[Token(Token = "0x6005438")]
				[Address(RVA = "0xAECB40", Offset = "0xAEBF40", VA = "0x180AECB40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011EC")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6005439")]
				[Address(RVA = "0xAECA40", Offset = "0xAEBE40", VA = "0x180AECA40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011ED")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600543A")]
				[Address(RVA = "0xAECC80", Offset = "0xAEC080", VA = "0x180AECC80", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011EE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AddFailureReason Reason
			{
				[Token(Token = "0x600543E")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(AddFailureReason);
				}
				[Token(Token = "0x600543F")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x600543B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error()
			{
			}

			[Token(Token = "0x600543C")]
			[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error(Error other)
			{
			}

			[Token(Token = "0x600543D")]
			[Address(RVA = "0xAEC020", Offset = "0xAEB420", VA = "0x180AEC020", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Error Clone()
			{
				return null;
			}

			[Token(Token = "0x6005440")]
			[Address(RVA = "0xAEC2B0", Offset = "0xAEB6B0", VA = "0x180AEC2B0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005441")]
			[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Error other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005442")]
			[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6005443")]
			[Address(RVA = "0xAEC460", Offset = "0xAEB860", VA = "0x180AEC460", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6005444")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6005445")]
			[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6005446")]
			[Address(RVA = "0xAEBF10", Offset = "0xAEB310", VA = "0x180AEBF10", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6005447")]
			[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Error other)
			{
			}

			[Token(Token = "0x6005448")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6005449")]
			[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20007F1")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Success : IMessage<Success>, IMessage, IEquatable<Success>, IDeepCloneable<Success>, IBufferMessage
		{
			[Token(Token = "0x4001B6A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Success> _parser;

			[Token(Token = "0x4001B6B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001B6C")]
			public const int BlockedFieldNumber = 1;

			[Token(Token = "0x4001B6D")]
			[FieldOffset(Offset = "0x18")]
			private ContactInformation blocked_;

			[Token(Token = "0x170011EF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Success> Parser
			{
				[Token(Token = "0x600544E")]
				[Address(RVA = "0xAF58A0", Offset = "0xAF4CA0", VA = "0x180AF58A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011F0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600544F")]
				[Address(RVA = "0xAF5650", Offset = "0xAF4A50", VA = "0x180AF5650")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011F1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6005450")]
				[Address(RVA = "0xAF5EF0", Offset = "0xAF52F0", VA = "0x180AF5EF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011F2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ContactInformation Blocked
			{
				[Token(Token = "0x6005454")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005455")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x6005451")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success()
			{
			}

			[Token(Token = "0x6005452")]
			[Address(RVA = "0xAF55E0", Offset = "0xAF49E0", VA = "0x180AF55E0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success(Success other)
			{
			}

			[Token(Token = "0x6005453")]
			[Address(RVA = "0xAF4810", Offset = "0xAF3C10", VA = "0x180AF4810", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success Clone()
			{
				return null;
			}

			[Token(Token = "0x6005456")]
			[Address(RVA = "0xAF4AA0", Offset = "0xAF3EA0", VA = "0x180AF4AA0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005457")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Success other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005458")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6005459")]
			[Address(RVA = "0xAF5090", Offset = "0xAF4490", VA = "0x180AF5090", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600545A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600545B")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600545C")]
			[Address(RVA = "0xAF45C0", Offset = "0xAF39C0", VA = "0x180AF45C0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600545D")]
			[Address(RVA = "0xAF4F20", Offset = "0xAF4320", VA = "0x180AF4F20", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Success other)
			{
			}

			[Token(Token = "0x600545E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600545F")]
			[Address(RVA = "0xAF5A90", Offset = "0xAF4E90", VA = "0x180AF5A90", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001B5B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BlockEvent> _parser;

	[Token(Token = "0x4001B5C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B5D")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4001B5E")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x4001B5F")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x4001B60")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x170011E5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BlockEvent> Parser
	{
		[Token(Token = "0x6005421")]
		[Address(RVA = "0xAE6C30", Offset = "0xAE6030", VA = "0x180AE6C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011E6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005422")]
		[Address(RVA = "0xAE6B20", Offset = "0xAE5F20", VA = "0x180AE6B20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005423")]
		[Address(RVA = "0xAE6FC0", Offset = "0xAE63C0", VA = "0x180AE6FC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Error Error
	{
		[Token(Token = "0x6005427")]
		[Address(RVA = "0xAE6BD0", Offset = "0xAE5FD0", VA = "0x180AE6BD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005428")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x170011E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Success Success
	{
		[Token(Token = "0x6005429")]
		[Address(RVA = "0xAE6C80", Offset = "0xAE6080", VA = "0x180AE6C80")]
		get
		{
			return null;
		}
		[Token(Token = "0x600542A")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x170011EA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x600542B")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x6005424")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BlockEvent()
	{
	}

	[Token(Token = "0x6005425")]
	[Address(RVA = "0xAE68F0", Offset = "0xAE5CF0", VA = "0x180AE68F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockEvent(BlockEvent other)
	{
	}

	[Token(Token = "0x6005426")]
	[Address(RVA = "0xAE60F0", Offset = "0xAE54F0", VA = "0x180AE60F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600542C")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearResult()
	{
	}

	[Token(Token = "0x600542D")]
	[Address(RVA = "0xAE6150", Offset = "0xAE5550", VA = "0x180AE6150", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600542E")]
	[Address(RVA = "0xAE62C0", Offset = "0xAE56C0", VA = "0x180AE62C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BlockEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600542F")]
	[Address(RVA = "0xAE63F0", Offset = "0xAE57F0", VA = "0x180AE63F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005430")]
	[Address(RVA = "0xAE6790", Offset = "0xAE5B90", VA = "0x180AE6790", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005431")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005432")]
	[Address(RVA = "0xAE6EB0", Offset = "0xAE62B0", VA = "0x180AE6EB0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005433")]
	[Address(RVA = "0xAE5FC0", Offset = "0xAE53C0", VA = "0x180AE5FC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005434")]
	[Address(RVA = "0xAE6520", Offset = "0xAE5920", VA = "0x180AE6520", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BlockEvent other)
	{
	}

	[Token(Token = "0x6005435")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005436")]
	[Address(RVA = "0xAE6CE0", Offset = "0xAE60E0", VA = "0x180AE6CE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
