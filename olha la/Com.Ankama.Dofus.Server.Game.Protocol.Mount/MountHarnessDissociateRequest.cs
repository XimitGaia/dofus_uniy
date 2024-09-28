using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200030F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountHarnessDissociateRequest : IMessage<MountHarnessDissociateRequest>, IMessage, IEquatable<MountHarnessDissociateRequest>, IDeepCloneable<MountHarnessDissociateRequest>, IBufferMessage
{
	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountHarnessDissociateRequest> _parser;

	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170006D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountHarnessDissociateRequest> Parser
	{
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0xD1D6E0", Offset = "0xD1CAE0", VA = "0x180D1D6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0xD1D630", Offset = "0xD1CA30", VA = "0x180D1D630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0xD1D730", Offset = "0xD1CB30", VA = "0x180D1D730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountHarnessDissociateRequest()
	{
	}

	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountHarnessDissociateRequest(MountHarnessDissociateRequest other)
	{
	}

	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0xD1D3D0", Offset = "0xD1C7D0", VA = "0x180D1D3D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountHarnessDissociateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0xD1D450", Offset = "0xD1C850", VA = "0x180D1D450", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountHarnessDissociateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0xD1D4D0", Offset = "0xD1C8D0", VA = "0x180D1D4D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001FC5")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountHarnessDissociateRequest other)
	{
	}

	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
