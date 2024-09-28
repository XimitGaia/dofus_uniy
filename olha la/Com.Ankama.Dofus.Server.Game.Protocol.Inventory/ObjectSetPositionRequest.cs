using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000386")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectSetPositionRequest : IMessage<ObjectSetPositionRequest>, IMessage, IEquatable<ObjectSetPositionRequest>, IDeepCloneable<ObjectSetPositionRequest>, IBufferMessage
{
	[Token(Token = "0x4000C2C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectSetPositionRequest> _parser;

	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C2E")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000C30")]
	public const int PositionFieldNumber = 2;

	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x1C")]
	private int position_;

	[Token(Token = "0x4000C32")]
	public const int QuantityFieldNumber = 3;

	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x20")]
	private int quantity_;

	[Token(Token = "0x170007D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectSetPositionRequest> Parser
	{
		[Token(Token = "0x6002490")]
		[Address(RVA = "0x992310", Offset = "0x991710", VA = "0x180992310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007DA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x992260", Offset = "0x991660", VA = "0x180992260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007DB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x992360", Offset = "0x991760", VA = "0x180992360", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectUid
	{
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170007DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002493")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectSetPositionRequest()
	{
	}

	[Token(Token = "0x6002494")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectSetPositionRequest(ObjectSetPositionRequest other)
	{
	}

	[Token(Token = "0x6002495")]
	[Address(RVA = "0x991FD0", Offset = "0x9913D0", VA = "0x180991FD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectSetPositionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600249C")]
	[Address(RVA = "0x992060", Offset = "0x991460", VA = "0x180992060", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600249D")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectSetPositionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600249E")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600249F")]
	[Address(RVA = "0x992100", Offset = "0x991500", VA = "0x180992100", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x991EF0", Offset = "0x9912F0", VA = "0x180991EF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectSetPositionRequest other)
	{
	}

	[Token(Token = "0x60024A4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
