using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element;

[Token(Token = "0x2000746")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LockableUseCodeRequest : IMessage<LockableUseCodeRequest>, IMessage, IEquatable<LockableUseCodeRequest>, IDeepCloneable<LockableUseCodeRequest>, IBufferMessage
{
	[Token(Token = "0x4001996")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LockableUseCodeRequest> _parser;

	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001998")]
	public const int CodeFieldNumber = 1;

	[Token(Token = "0x4001999")]
	[FieldOffset(Offset = "0x18")]
	private string code_;

	[Token(Token = "0x170010B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LockableUseCodeRequest> Parser
	{
		[Token(Token = "0x6004E16")]
		[Address(RVA = "0xAC35C0", Offset = "0xAC29C0", VA = "0x180AC35C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004E17")]
		[Address(RVA = "0xAC3510", Offset = "0xAC2910", VA = "0x180AC3510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0xAC36D0", Offset = "0xAC2AD0", VA = "0x180AC36D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010BA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Code
	{
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0xAC37B0", Offset = "0xAC2BB0", VA = "0x180AC37B0")]
		set
		{
		}
	}

	[Token(Token = "0x6004E19")]
	[Address(RVA = "0xAC3420", Offset = "0xAC2820", VA = "0x180AC3420")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableUseCodeRequest()
	{
	}

	[Token(Token = "0x6004E1A")]
	[Address(RVA = "0xAC3470", Offset = "0xAC2870", VA = "0x180AC3470")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LockableUseCodeRequest(LockableUseCodeRequest other)
	{
	}

	[Token(Token = "0x6004E1B")]
	[Address(RVA = "0xAC30E0", Offset = "0xAC24E0", VA = "0x180AC30E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableUseCodeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004E1E")]
	[Address(RVA = "0xAC31B0", Offset = "0xAC25B0", VA = "0x180AC31B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E1F")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LockableUseCodeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E20")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004E21")]
	[Address(RVA = "0xAC32C0", Offset = "0xAC26C0", VA = "0x180AC32C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004E22")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004E23")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004E24")]
	[Address(RVA = "0xAC3050", Offset = "0xAC2450", VA = "0x180AC3050", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004E25")]
	[Address(RVA = "0xAC3260", Offset = "0xAC2660", VA = "0x180AC3260", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LockableUseCodeRequest other)
	{
	}

	[Token(Token = "0x6004E26")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004E27")]
	[Address(RVA = "0xAC3610", Offset = "0xAC2A10", VA = "0x180AC3610", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
