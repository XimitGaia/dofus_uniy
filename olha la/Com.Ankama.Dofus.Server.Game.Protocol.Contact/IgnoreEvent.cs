using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007DA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class IgnoreEvent : IMessage<IgnoreEvent>, IMessage, IEquatable<IgnoreEvent>, IDeepCloneable<IgnoreEvent>, IBufferMessage
{
	[Token(Token = "0x20007DB")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x4001B34")]
		None,
		[Token(Token = "0x4001B35")]
		Error,
		[Token(Token = "0x4001B36")]
		Success
	}

	[Token(Token = "0x20007DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20007DD")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Error : IMessage<Error>, IMessage, IEquatable<Error>, IDeepCloneable<Error>, IBufferMessage
		{
			[Token(Token = "0x4001B37")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Error> _parser;

			[Token(Token = "0x4001B38")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001B39")]
			public const int ReasonFieldNumber = 1;

			[Token(Token = "0x4001B3A")]
			[FieldOffset(Offset = "0x18")]
			private AddFailureReason reason_;

			[Token(Token = "0x170011CC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Error> Parser
			{
				[Token(Token = "0x6005399")]
				[Address(RVA = "0xAECBE0", Offset = "0xAEBFE0", VA = "0x180AECBE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011CD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600539A")]
				[Address(RVA = "0xAEC940", Offset = "0xAEBD40", VA = "0x180AEC940")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011CE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600539B")]
				[Address(RVA = "0xAECD30", Offset = "0xAEC130", VA = "0x180AECD30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011CF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AddFailureReason Reason
			{
				[Token(Token = "0x600539F")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(AddFailureReason);
				}
				[Token(Token = "0x60053A0")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x600539C")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error()
			{
			}

			[Token(Token = "0x600539D")]
			[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error(Error other)
			{
			}

			[Token(Token = "0x600539E")]
			[Address(RVA = "0xAEBFA0", Offset = "0xAEB3A0", VA = "0x180AEBFA0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Error Clone()
			{
				return null;
			}

			[Token(Token = "0x60053A1")]
			[Address(RVA = "0xAEC1A0", Offset = "0xAEB5A0", VA = "0x180AEC1A0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053A2")]
			[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Error other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053A3")]
			[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60053A4")]
			[Address(RVA = "0xAEC410", Offset = "0xAEB810", VA = "0x180AEC410", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60053A5")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60053A6")]
			[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60053A7")]
			[Address(RVA = "0xAEBE80", Offset = "0xAEB280", VA = "0x180AEBE80", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60053A8")]
			[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Error other)
			{
			}

			[Token(Token = "0x60053A9")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60053AA")]
			[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20007DF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Success : IMessage<Success>, IMessage, IEquatable<Success>, IDeepCloneable<Success>, IBufferMessage
		{
			[Token(Token = "0x4001B3C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Success> _parser;

			[Token(Token = "0x4001B3D")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001B3E")]
			public const int IgnoredFieldNumber = 1;

			[Token(Token = "0x4001B3F")]
			[FieldOffset(Offset = "0x18")]
			private ContactInformation ignored_;

			[Token(Token = "0x170011D0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Success> Parser
			{
				[Token(Token = "0x60053AF")]
				[Address(RVA = "0xAF5940", Offset = "0xAF4D40", VA = "0x180AF5940")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011D1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60053B0")]
				[Address(RVA = "0xAF57D0", Offset = "0xAF4BD0", VA = "0x180AF57D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011D2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60053B1")]
				[Address(RVA = "0xAF5FA0", Offset = "0xAF53A0", VA = "0x180AF5FA0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011D3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ContactInformation Ignored
			{
				[Token(Token = "0x60053B5")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x60053B6")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x60053B2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success()
			{
			}

			[Token(Token = "0x60053B3")]
			[Address(RVA = "0xAF55E0", Offset = "0xAF49E0", VA = "0x180AF55E0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success(Success other)
			{
			}

			[Token(Token = "0x60053B4")]
			[Address(RVA = "0xAF4770", Offset = "0xAF3B70", VA = "0x180AF4770", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success Clone()
			{
				return null;
			}

			[Token(Token = "0x60053B7")]
			[Address(RVA = "0xAF4B50", Offset = "0xAF3F50", VA = "0x180AF4B50", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053B8")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Success other)
			{
				return default(bool);
			}

			[Token(Token = "0x60053B9")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60053BA")]
			[Address(RVA = "0xAF50E0", Offset = "0xAF44E0", VA = "0x180AF50E0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60053BB")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60053BC")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60053BD")]
			[Address(RVA = "0xAF4530", Offset = "0xAF3930", VA = "0x180AF4530", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60053BE")]
			[Address(RVA = "0xAF4D80", Offset = "0xAF4180", VA = "0x180AF4D80", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Success other)
			{
			}

			[Token(Token = "0x60053BF")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60053C0")]
			[Address(RVA = "0xAF5B90", Offset = "0xAF4F90", VA = "0x180AF5B90", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001B2D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<IgnoreEvent> _parser;

	[Token(Token = "0x4001B2E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B2F")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4001B30")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x4001B31")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x4001B32")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x170011C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IgnoreEvent> Parser
	{
		[Token(Token = "0x6005382")]
		[Address(RVA = "0xAF3550", Offset = "0xAF2950", VA = "0x180AF3550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005383")]
		[Address(RVA = "0xAF3440", Offset = "0xAF2840", VA = "0x180AF3440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005384")]
		[Address(RVA = "0xAF38E0", Offset = "0xAF2CE0", VA = "0x180AF38E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Error Error
	{
		[Token(Token = "0x6005388")]
		[Address(RVA = "0xAF34F0", Offset = "0xAF28F0", VA = "0x180AF34F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x170011CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Success Success
	{
		[Token(Token = "0x600538A")]
		[Address(RVA = "0xAF35A0", Offset = "0xAF29A0", VA = "0x180AF35A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600538B")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x170011CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x600538C")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x6005385")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public IgnoreEvent()
	{
	}

	[Token(Token = "0x6005386")]
	[Address(RVA = "0xAF3210", Offset = "0xAF2610", VA = "0x180AF3210")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IgnoreEvent(IgnoreEvent other)
	{
	}

	[Token(Token = "0x6005387")]
	[Address(RVA = "0xAF2A10", Offset = "0xAF1E10", VA = "0x180AF2A10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IgnoreEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600538D")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearResult()
	{
	}

	[Token(Token = "0x600538E")]
	[Address(RVA = "0xAF2A70", Offset = "0xAF1E70", VA = "0x180AF2A70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600538F")]
	[Address(RVA = "0xAF2BE0", Offset = "0xAF1FE0", VA = "0x180AF2BE0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IgnoreEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005390")]
	[Address(RVA = "0xAF2D10", Offset = "0xAF2110", VA = "0x180AF2D10", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005391")]
	[Address(RVA = "0xAF30B0", Offset = "0xAF24B0", VA = "0x180AF30B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005392")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005393")]
	[Address(RVA = "0xAF37D0", Offset = "0xAF2BD0", VA = "0x180AF37D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005394")]
	[Address(RVA = "0xAF28E0", Offset = "0xAF1CE0", VA = "0x180AF28E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005395")]
	[Address(RVA = "0xAF2E40", Offset = "0xAF2240", VA = "0x180AF2E40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IgnoreEvent other)
	{
	}

	[Token(Token = "0x6005396")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005397")]
	[Address(RVA = "0xAF3600", Offset = "0xAF2A00", VA = "0x180AF3600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
