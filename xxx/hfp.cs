// Ankama.Dofus.Protocol.Game, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// hfp
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

[Token(Token = "0x200006A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class hfp : IMessage<hfp>, IMessage, IEquatable<hfp>, IDeepCloneable<hfp>, IBufferMessage
{
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<hfp> dixn;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet dixo;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x18")]
	private int dixp;

	[Token(Token = "0x400014D")]
	public const int dixq = 1;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x1C")]
	private hfh dixr;

	[Token(Token = "0x400014F")]
	public const int dixs = 2;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<hgc> dixt;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<hgc> dixu;

	[Token(Token = "0x4000152")]
	public const int dixv = 3;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x10")]
	private static readonly long dixw;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x28")]
	private long dixx;

	[Token(Token = "0x170000C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<hfp> egjp
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x6E9DD0", Offset = "0x6E85D0", VA = "0x1806E9DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor egjq
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x6E9E20", Offset = "0x6E8620", VA = "0x1806E9E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor egjr
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x6E9EA0", Offset = "0x6E86A0", VA = "0x1806E9EA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public hfh egjs
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x61B740", Offset = "0x619F40", VA = "0x18061B740")]
		get
		{
			return default(hfh);
		}
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x61B770", Offset = "0x619F70", VA = "0x18061B770")]
		set
		{
		}
	}

	[Token(Token = "0x170000C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<hgc> egjt
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x56EF60", Offset = "0x56D760", VA = "0x18056EF60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long egju
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x6E9F50", Offset = "0x6E8750", VA = "0x1806E9F50")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x6E9FC0", Offset = "0x6E87C0", VA = "0x1806E9FC0")]
		set
		{
		}
	}

	[Token(Token = "0x170000CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool egjv
	{
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x61B530", Offset = "0x619D30", VA = "0x18061B530")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x6E9C40", Offset = "0x6E8440", VA = "0x1806E9C40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public hfp()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x6E9CC0", Offset = "0x6E84C0", VA = "0x1806E9CC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public hfp(hfp a)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x6E9580", Offset = "0x6E7D80", VA = "0x1806E9580", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public hfp Clone()
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x6C6FD0", Offset = "0x6C57D0", VA = "0x1806C6FD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void blyi()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x6E9780", Offset = "0x6E7F80", VA = "0x1806E9780", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x6E96C0", Offset = "0x6E7EC0", VA = "0x1806E96C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(hfp other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x6E9880", Offset = "0x6E8080", VA = "0x1806E9880", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x6E9A20", Offset = "0x6E8220", VA = "0x1806E9A20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x6B8A70", Offset = "0x6B7270", VA = "0x1806B8A70", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x6E9FD0", Offset = "0x6E87D0", VA = "0x1806E9FD0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void blyj(ref WriteContext a)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x6E9420", Offset = "0x6E7C20", VA = "0x1806E9420", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x6E9980", Offset = "0x6E8180", VA = "0x1806E9980", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(hfp other)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x6B89F0", Offset = "0x6B71F0", VA = "0x1806B89F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x6EA120", Offset = "0x6E8920", VA = "0x1806EA120", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void blyk(ref ParseContext a)
	{
	}
}
