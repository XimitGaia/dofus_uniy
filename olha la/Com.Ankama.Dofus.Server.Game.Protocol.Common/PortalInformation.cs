using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AF0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PortalInformation : IMessage<PortalInformation>, IMessage, IEquatable<PortalInformation>, IDeepCloneable<PortalInformation>, IBufferMessage
{
	[Token(Token = "0x4002850")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PortalInformation> _parser;

	[Token(Token = "0x4002851")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002852")]
	public const int PortalIdFieldNumber = 1;

	[Token(Token = "0x4002853")]
	[FieldOffset(Offset = "0x18")]
	private int portalId_;

	[Token(Token = "0x4002854")]
	public const int AreaIdFieldNumber = 2;

	[Token(Token = "0x4002855")]
	[FieldOffset(Offset = "0x1C")]
	private int areaId_;

	[Token(Token = "0x17001925")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PortalInformation> Parser
	{
		[Token(Token = "0x60072E0")]
		[Address(RVA = "0xBFBDF0", Offset = "0xBFB1F0", VA = "0x180BFBDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001926")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60072E1")]
		[Address(RVA = "0xBFBD40", Offset = "0xBFB140", VA = "0x180BFBD40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001927")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60072E2")]
		[Address(RVA = "0xBFBE40", Offset = "0xBFB240", VA = "0x180BFBE40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001928")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PortalId
	{
		[Token(Token = "0x60072E6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60072E7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001929")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AreaId
	{
		[Token(Token = "0x60072E8")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60072E9")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60072E3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PortalInformation()
	{
	}

	[Token(Token = "0x60072E4")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PortalInformation(PortalInformation other)
	{
	}

	[Token(Token = "0x60072E5")]
	[Address(RVA = "0xBFBAC0", Offset = "0xBFAEC0", VA = "0x180BFBAC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PortalInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60072EA")]
	[Address(RVA = "0xBFBB50", Offset = "0xBFAF50", VA = "0x180BFBB50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60072EB")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PortalInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60072EC")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60072ED")]
	[Address(RVA = "0xBFBBE0", Offset = "0xBFAFE0", VA = "0x180BFBBE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60072EE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60072EF")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60072F0")]
	[Address(RVA = "0xBFBA00", Offset = "0xBFAE00", VA = "0x180BFBA00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60072F1")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PortalInformation other)
	{
	}

	[Token(Token = "0x60072F2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60072F3")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
