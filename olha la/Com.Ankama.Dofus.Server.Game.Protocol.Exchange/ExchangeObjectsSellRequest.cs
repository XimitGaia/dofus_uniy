using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000678")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectsSellRequest : IMessage<ExchangeObjectsSellRequest>, IMessage, IEquatable<ExchangeObjectsSellRequest>, IDeepCloneable<ExchangeObjectsSellRequest>, IBufferMessage
{
	[Token(Token = "0x2000679")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200067A")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ExchangeObject : IMessage<ExchangeObject>, IMessage, IEquatable<ExchangeObject>, IDeepCloneable<ExchangeObject>, IBufferMessage
		{
			[Token(Token = "0x40016A2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ExchangeObject> _parser;

			[Token(Token = "0x40016A3")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40016A4")]
			public const int ObjectUidFieldNumber = 1;

			[Token(Token = "0x40016A5")]
			[FieldOffset(Offset = "0x18")]
			private int objectUid_;

			[Token(Token = "0x40016A6")]
			public const int QuantityFieldNumber = 2;

			[Token(Token = "0x40016A7")]
			[FieldOffset(Offset = "0x1C")]
			private int quantity_;

			[Token(Token = "0x17000EDD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ExchangeObject> Parser
			{
				[Token(Token = "0x600457D")]
				[Address(RVA = "0xA922E0", Offset = "0xA916E0", VA = "0x180A922E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000EDE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600457E")]
				[Address(RVA = "0xA92260", Offset = "0xA91660", VA = "0x180A92260")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000EDF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600457F")]
				[Address(RVA = "0xA92330", Offset = "0xA91730", VA = "0x180A92330", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000EE0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ObjectUid
			{
				[Token(Token = "0x6004583")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004584")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000EE1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Quantity
			{
				[Token(Token = "0x6004585")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004586")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x6004580")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ExchangeObject()
			{
			}

			[Token(Token = "0x6004581")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ExchangeObject(ExchangeObject other)
			{
			}

			[Token(Token = "0x6004582")]
			[Address(RVA = "0xA91FE0", Offset = "0xA913E0", VA = "0x180A91FE0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExchangeObject Clone()
			{
				return null;
			}

			[Token(Token = "0x6004587")]
			[Address(RVA = "0xA92070", Offset = "0xA91470", VA = "0x180A92070", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004588")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ExchangeObject other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004589")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600458A")]
			[Address(RVA = "0xA92100", Offset = "0xA91500", VA = "0x180A92100", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600458B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600458C")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600458D")]
			[Address(RVA = "0xA91F20", Offset = "0xA91320", VA = "0x180A91F20", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600458E")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ExchangeObject other)
			{
			}

			[Token(Token = "0x600458F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004590")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400169D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectsSellRequest> _parser;

	[Token(Token = "0x400169E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400169F")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.ExchangeObject> _repeated_objects_codec;

	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.ExchangeObject> objects_;

	[Token(Token = "0x17000ED9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectsSellRequest> Parser
	{
		[Token(Token = "0x600456B")]
		[Address(RVA = "0xA94F80", Offset = "0xA94380", VA = "0x180A94F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EDA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600456C")]
		[Address(RVA = "0xA94ED0", Offset = "0xA942D0", VA = "0x180A94ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EDB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600456D")]
		[Address(RVA = "0xA95190", Offset = "0xA94590", VA = "0x180A95190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EDC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.ExchangeObject> Objects
	{
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600456E")]
	[Address(RVA = "0xA94DC0", Offset = "0xA941C0", VA = "0x180A94DC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectsSellRequest()
	{
	}

	[Token(Token = "0x600456F")]
	[Address(RVA = "0xA94E40", Offset = "0xA94240", VA = "0x180A94E40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsSellRequest(ExchangeObjectsSellRequest other)
	{
	}

	[Token(Token = "0x6004570")]
	[Address(RVA = "0xA94910", Offset = "0xA93D10", VA = "0x180A94910", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsSellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004572")]
	[Address(RVA = "0xA949D0", Offset = "0xA93DD0", VA = "0x180A949D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004573")]
	[Address(RVA = "0xA94AB0", Offset = "0xA93EB0", VA = "0x180A94AB0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectsSellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004574")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004575")]
	[Address(RVA = "0xA94BC0", Offset = "0xA93FC0", VA = "0x180A94BC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004576")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004577")]
	[Address(RVA = "0xA950E0", Offset = "0xA944E0", VA = "0x180A950E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004578")]
	[Address(RVA = "0xA94870", Offset = "0xA93C70", VA = "0x180A94870", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004579")]
	[Address(RVA = "0xA94B40", Offset = "0xA93F40", VA = "0x180A94B40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectsSellRequest other)
	{
	}

	[Token(Token = "0x600457A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600457B")]
	[Address(RVA = "0xA94FD0", Offset = "0xA943D0", VA = "0x180A94FD0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
