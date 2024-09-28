using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object;

[Token(Token = "0x2000342")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LivingObjectChangeSkinRequest : IMessage<LivingObjectChangeSkinRequest>, IMessage, IEquatable<LivingObjectChangeSkinRequest>, IDeepCloneable<LivingObjectChangeSkinRequest>, IBufferMessage
{
	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LivingObjectChangeSkinRequest> _parser;

	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B3A")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000B3C")]
	public const int PositionFieldNumber = 2;

	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x1C")]
	private int position_;

	[Token(Token = "0x4000B3E")]
	public const int SkinIdFieldNumber = 3;

	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x20")]
	private int skinId_;

	[Token(Token = "0x17000736")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LivingObjectChangeSkinRequest> Parser
	{
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x9780F0", Offset = "0x9774F0", VA = "0x1809780F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000737")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x978040", Offset = "0x977440", VA = "0x180978040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000738")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x9781E0", Offset = "0x9775E0", VA = "0x1809781E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000739")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectUid
	{
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700073A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700073B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SkinId
	{
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60021B1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectChangeSkinRequest()
	{
	}

	[Token(Token = "0x60021B2")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LivingObjectChangeSkinRequest(LivingObjectChangeSkinRequest other)
	{
	}

	[Token(Token = "0x60021B3")]
	[Address(RVA = "0x977D10", Offset = "0x977110", VA = "0x180977D10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectChangeSkinRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x977DA0", Offset = "0x9771A0", VA = "0x180977DA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021BB")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LivingObjectChangeSkinRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60021BD")]
	[Address(RVA = "0x977EE0", Offset = "0x9772E0", VA = "0x180977EE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x977C30", Offset = "0x977030", VA = "0x180977C30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LivingObjectChangeSkinRequest other)
	{
	}

	[Token(Token = "0x60021C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60021C3")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
