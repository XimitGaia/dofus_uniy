using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C5E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationListenRequest : IMessage<AllianceApplicationListenRequest>, IMessage, IEquatable<AllianceApplicationListenRequest>, IDeepCloneable<AllianceApplicationListenRequest>, IBufferMessage
{
	[Token(Token = "0x4002DC6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationListenRequest> _parser;

	[Token(Token = "0x4002DC7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DC8")]
	public const int StateFieldNumber = 1;

	[Token(Token = "0x4002DC9")]
	[FieldOffset(Offset = "0x18")]
	private bool state_;

	[Token(Token = "0x17001C87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationListenRequest> Parser
	{
		[Token(Token = "0x600821B")]
		[Address(RVA = "0xC715F0", Offset = "0xC709F0", VA = "0x180C715F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C88")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600821C")]
		[Address(RVA = "0xC71540", Offset = "0xC70940", VA = "0x180C71540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C89")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600821D")]
		[Address(RVA = "0xC71640", Offset = "0xC70A40", VA = "0x180C71640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C8A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool State
	{
		[Token(Token = "0x6008221")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008222")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x600821E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationListenRequest()
	{
	}

	[Token(Token = "0x600821F")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationListenRequest(AllianceApplicationListenRequest other)
	{
	}

	[Token(Token = "0x6008220")]
	[Address(RVA = "0xC71230", Offset = "0xC70630", VA = "0x180C71230", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationListenRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008223")]
	[Address(RVA = "0xC712B0", Offset = "0xC706B0", VA = "0x180C712B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008224")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationListenRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008225")]
	[Address(RVA = "0xC71340", Offset = "0xC70740", VA = "0x180C71340", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008226")]
	[Address(RVA = "0xC713E0", Offset = "0xC707E0", VA = "0x180C713E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008227")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008228")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008229")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600822A")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationListenRequest other)
	{
	}

	[Token(Token = "0x600822B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600822C")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
