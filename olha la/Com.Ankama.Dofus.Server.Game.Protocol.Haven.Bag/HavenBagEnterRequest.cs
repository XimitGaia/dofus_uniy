using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000419")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagEnterRequest : IMessage<HavenBagEnterRequest>, IMessage, IEquatable<HavenBagEnterRequest>, IDeepCloneable<HavenBagEnterRequest>, IBufferMessage
{
	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagEnterRequest> _parser;

	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E57")]
	public const int OwnerFieldNumber = 1;

	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x18")]
	private long owner_;

	[Token(Token = "0x1700094E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagEnterRequest> Parser
	{
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x9BA7E0", Offset = "0x9B9BE0", VA = "0x1809BA7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700094F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x9BA730", Offset = "0x9B9B30", VA = "0x1809BA730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000950")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x9BA830", Offset = "0x9B9C30", VA = "0x1809BA830", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000951")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Owner
	{
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6002B48")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagEnterRequest()
	{
	}

	[Token(Token = "0x6002B49")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagEnterRequest(HavenBagEnterRequest other)
	{
	}

	[Token(Token = "0x6002B4A")]
	[Address(RVA = "0x9BA4C0", Offset = "0x9B98C0", VA = "0x1809BA4C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEnterRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002B4D")]
	[Address(RVA = "0x9BA540", Offset = "0x9B9940", VA = "0x1809BA540", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B4E")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagEnterRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B4F")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002B50")]
	[Address(RVA = "0x9BA5D0", Offset = "0x9B99D0", VA = "0x1809BA5D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002B51")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002B52")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002B53")]
	[Address(RVA = "0x9BA430", Offset = "0x9B9830", VA = "0x1809BA430", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002B54")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagEnterRequest other)
	{
	}

	[Token(Token = "0x6002B55")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002B56")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
